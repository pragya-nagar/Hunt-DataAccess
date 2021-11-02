using System;
using System.Collections.Generic;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedEvent
    {
        public static List<Event> GetEvents(ISynergyContext synergyContext)
        {
            var list = new List<Event>();
            int d = 0;
            foreach (User user in synergyContext.User)
            {
                for (int i = 1; i < 10; i++)
                {
                    d++;
                    list.Add(new Event
                    {
                        Id = Guid.NewGuid(),
                        CountyId = i,
                        EventNumber = $"Number #{d} properties",
                        SaleDate = DateTime.Now,
                        DueDate = DateTime.Now.AddDays(+i),
                        CurrentTask = "not clear",
                        Progress = "not clear",
                        FundingDate = DateTime.Now,
                        RegistrationDeadline = DateTime.Now.AddDays(+i),
                        DepositDeadline = DateTime.Now.AddDays(+i),
                        DepositAmount = 0,
                        TreasurerFee = 0,
                        InterestRate = 0,
                        AuctionAddress = "Auction Address",
                        AuctionStartTime = DateTime.Now.AddDays(+i),
                        TreasurerName = $"Treasurer Name #{i}",
                        TreasurerEmail = "email@email.com",
                        EstimatedPurchaseAmount = null,
                        EstimatedDepositAmount = null,
                        RefundAmount = null,
                        IsLocked = false,
                        StateId = 1,
                        EventTypeId = 1,
                        AuctionTypeId = 1,
                        SaleDateStatusId = 1,
                        EventEntityId = 1,
                        FinalPaymentTypeId = 1,
                        UserId = user.Id,
                        CreatedBy = user,
                        CreatedOn = DateTime.Now,
                        ModifiedBy = user,
                        ModifiedOn = DateTime.Now,
                    });
                }
            }

            return list;
        }
    }
}
