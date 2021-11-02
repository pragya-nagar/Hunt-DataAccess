using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Synergy.Common.Abstracts;
using Synergy.DataAccess.Abstractions;
using Synergy.DataAccess.Context;
using Synergy.DataAccess.Dictionaries.Queries;
using Synergy.DataAccess.Dictionaries.Queries.Interfaces;
using Synergy.DataAccess.Dictionaries.Queries.Models;
using Synergy.DataAccess.Entities;
using Synergy.DataAccess.Entities.OpportunityEntities;

namespace Synergy.DataAccess.Utils.Queries
{
    internal class Program
    {
        private static void Main()
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            var connectionString = configuration.GetConnectionString("SynergyReadDb");

            var services = new ServiceCollection();

            services.RegisterSynergyEncriptionService(false, configuration);

            services.RegisterSynergyContext(connectionString, true);
            services.AddSingleton<IOperationContextAccessor, TestContextAccessor>();

            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddConsole();
                loggingBuilder.AddDebug();
            });

            services.AddAutoMapper(mapperConfig =>
            {
                mapperConfig.ForAllPropertyMaps(map => map.SourceType?.IsEnum == true, (map, exp) =>
                {
                    exp.PreCondition((source, target, context) =>
                    {
                        var info = (PropertyInfo)map.SourceMember;
                        return System.Enum.IsDefined(map.SourceType, info.GetValue(source));
                    });
                });
            }, Assembly.Load("Synergy.DataAccess.Abstractions"),
               Assembly.Load("Synergy.DataAccess.Dictionaries.Queries"));
            services.RegisterDictionariesQueries(connectionString);

            ParalelTasks(services);
            Encription(services);

            Console.WriteLine("done!");
            Console.ReadLine();
        }

        private static void Encription(ServiceCollection services)
        {
            var context = services.BuildServiceProvider().GetService<ISynergyContext>();

            context.Opportunity.Add(new Opportunity
            {
                Id = Guid.NewGuid(),
                UserId = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                LeadId = context.Lead.First().Id,
                OpportunityStageId = 1,
                OpportunityPropertyTypeId = 1,
                CreatedById = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                ModifiedById = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                OpportunityBorrowers = new List<OpportunityBorrower>
                    {
                        new OpportunityBorrower
                        {
                            Id = Guid.NewGuid(),
                            Order = 0,
                            DateOfBirth = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                            SSN = "BC123456789011",
                            CreatedById = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                            ModifiedById = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                        },
                        new OpportunityBorrower
                        {
                            Id = Guid.NewGuid(),
                            Order = 1,
                            DateOfBirth = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                            SSN = "NeWsSn",
                            CreatedById = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                            ModifiedById = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                        },
                    },
            });

            context.SaveChanges();

            var opportunities = context.Opportunity.Include(o => o.OpportunityBorrowers).ToList();
        }

        private static void ParalelTasks(ServiceCollection services)
        {
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var cnt = 0;

                Parallel.For(0, 1000, new ParallelOptions { MaxDegreeOfParallelism = 20, }, (i) =>
                {
                    using (var serviceScope = serviceProvider.CreateScope())
                    {
                        using (var scope = new TransactionScope(
                            TransactionScopeOption.Required,
                            new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted, Timeout = TimeSpan.FromMinutes(20) },
                            TransactionScopeAsyncFlowOption.Enabled))
                        {
                            try
                            {
                                var logger = serviceScope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                                logger.LogInformation("DataChangesAsync started #{n}", i);
                                DataChangesAsync(serviceScope.ServiceProvider).GetAwaiter().GetResult();
                                logger.LogInformation("DataChangesAsync finished #{n}", i);

                                Interlocked.Increment(ref cnt);

                                scope.Complete();
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                });
            }
        }

        private static async System.Threading.Tasks.Task DataChangesAsync(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ISynergyContext>();
            var op = serviceProvider.GetService<IOperationContextAccessor>();

            var id = Guid.NewGuid();

            context.Bid.Add(new Bid
            {
                Id = id,
                Entity = "e1",
                Portfolio = "p1",
                Number = "n1" + Guid.NewGuid().ToString(),
                EventId = Guid.Parse("d1004104-b214-4457-832d-662c8d14b40d"),
                CreatedById = op.Current.UserId,
                CreatedOn = DateTime.UtcNow,
                ModifiedById = op.Current.UserId,
                ModifiedOn = DateTime.UtcNow,
            });

            await context.SaveChangesAsync().ConfigureAwait(false);

            var bid = context.Bid.FirstOrDefault(x => x.Id == id);

            bid.ModifiedOn = DateTime.UtcNow.AddDays(1);

            await context.SaveChangesAsync().ConfigureAwait(false);

            context.Bid.Remove(bid);

            await context.SaveChangesAsync().ConfigureAwait(false);
        }

        private static void DictionariesQueries(ServiceProvider serviceProvider)
        {
            var statesDictionaryQuery = serviceProvider.GetService<IGetStatesDictionaryQuery>();
            var statesDicrionary = statesDictionaryQuery.Search("oh").Exeсute();

            var userDictionaryQuery = serviceProvider.GetService<IGetUsersDictionaryQuery>();
            var usersDictionaryQuery = userDictionaryQuery.Search("dmytro andreyev").Exeсute();

            var campaignQuery = serviceProvider.GetService<IGetCampaignTypesQuery>();
            IEnumerable<CampaignTypeModel> campaignTypes = campaignQuery.Exeсute();
            IEnumerable<CampaignTypeModel> campaignTypesAsync = campaignQuery.ExeсuteAsync().Result;

            var internalLandUseCodesQuery = serviceProvider.GetService<IGetInternalLandUseCodesQuery>();
            IEnumerable<Abstractions.Models.FastEntityModel<int>> internalLandUseCodes = internalLandUseCodesQuery.Exeсute();

            var generalLandUseCodesQuer = serviceProvider.GetService<IGetGeneralLandUseCodesQuery>();
            IEnumerable<Abstractions.Models.FastEntityModel<int>> generalLandUseCodes = generalLandUseCodesQuer.Exeсute();

            var propertyDisplayStrategiesDictionaryQuery = serviceProvider.GetService<IGetPropertyDisplayStrategiesDictionaryQuery>();
            IEnumerable<Abstractions.Models.FastEntityModel<int>> propertyDisplayStrategies = propertyDisplayStrategiesDictionaryQuery.Exeсute();
        }

        internal class TestContextAccessor : IOperationContextAccessor, IOperationContext
        {
            private static readonly Guid _correlation = Guid.NewGuid();

            public IOperationContext Current => new TestContextAccessor
            {
                CorrelationId = _correlation,
                UserId = Guid.Parse("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                UserName = "Oleksandr Lialka",
            };

            public Guid CorrelationId { get; private set; }

            public Guid UserId { get; private set; }

            public string UserName { get; private set; }
        }
    }
}