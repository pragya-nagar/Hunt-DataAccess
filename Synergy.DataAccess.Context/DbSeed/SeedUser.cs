using System;
using System.Collections.Generic;
using System.Linq;

using Synergy.DataAccess.Entities;

namespace Synergy.DataAccess.Context.DbSeed
{
    public static class SeedUser
    {
        public static List<User> GetUsers(ISynergyContext synergyContext, Guid systemUser)
        {
            var list = new List<User>();

            var userExist = synergyContext.User.FirstOrDefault(x => x.Id == Guid.Parse("a08a87e2-b66a-4b64-8db8-98ccd5463893"));
            if (userExist == null)
            {
                list.Add(new User
                {
                    Id = Guid.Parse("a08a87e2-b66a-4b64-8db8-98ccd5463893"),
                    Email = "dandreyev@corevalue.net",
                    FirstName = "Dmytro",
                    LastName = "Andreyev",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                });
            }

            list.AddRange(GetUsersFromFile(systemUser));

            return list;
        }

        public static List<User> GetUsersFromFile(Guid systemUser)
        {
            return new List<User>
            {
                new User
                {
                    Id = new Guid("41bb570e-9e31-4571-b13e-2bcafdf7644f"),
                    Email = "ovirga@corevalue.net",
                    FirstName = "Oleksandr",
                    LastName = "Virga",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("b304e6f2-5731-4314-a015-25bdf6b9b4e3"),
                    Email = "kkantor@corevalue.net",
                    FirstName = "Khrystyna",
                    LastName = "Kantor",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("4ece5cf1-7975-440c-a7a5-98d56d12403b"),
                    Email = "mkomarnytska@corevalue.net",
                    FirstName = "Marta",
                    LastName = "Komarnytska",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("50967764-4d72-4ece-860a-5b210d396489"),
                    Email = "thusieva@corevalue.net",
                    FirstName = "Tetiana",
                    LastName = "Husieva",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("304f1ffa-a0f8-4311-8afe-ce1a3ee75c73"),
                    Email = "vbondar@corevalue.net",
                    FirstName = "Vitaliy",
                    LastName = "Bondar",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("7229ffa6-f9d9-4aa6-a53d-ee54a6024514"),
                    Email = "dslipak@corevalue.net",
                    FirstName = "Dmytro",
                    LastName = "Slipak",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("db82b793-5cbf-4548-bb9f-b9c414f0be21"),
                    Email = "rdovhanyk@corevalue.net",
                    FirstName = "Roman",
                    LastName = "Dovhanyk",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("ea601e87-66ee-4350-b408-b2f235c37f55"),
                    Email = "ofedotov@corevalue.net",
                    FirstName = "Oleh",
                    LastName = "Fedotov",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("1ca697f1-3be9-4aff-959a-bb144cbd77c8"),
                    Email = "rkramar@corevalue.net",
                    FirstName = "Roman",
                    LastName = "Kramar",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("e6aaffa7-78c1-437e-b304-945bdf760a42"),
                    Email = "ohoncharenko@corevalue.net",
                    FirstName = "Oleksandr",
                    LastName = "Honcharenko",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("13624776-cf43-4a38-8ce5-128c6016d578"),
                    Email = "iboben@corevalue.net",
                    FirstName = "Ihor",
                    LastName = "Boben",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("39d20e5a-1b63-4cb9-97c0-87da9b631f3f"),
                    Email = "srei@corevalue.net",
                    FirstName = "Serhiy",
                    LastName = "Rei",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("62384645-6414-41d7-a6ef-3f89c499137d"),
                    Email = "vgolovchak@corevalue.net",
                    FirstName = "Vasyl",
                    LastName = "Golovchak",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("0e1ec1c0-7e03-45ee-af29-249ada5a5af1"),
                    Email = "ymylian@corevalue.net",
                    FirstName = "Yulian",
                    LastName = "Myliyan",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("de8bb715-53f9-462f-b871-c8ee435ee20b"),
                    Email = "rtsikailo@corevalue.net",
                    FirstName = "Roman",
                    LastName = "Tsikalo",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("3987f89f-d74a-4257-bfa3-71dd957d68b4"),
                    Email = "otarianyk@corevalue.net",
                    FirstName = "Oleksandra",
                    LastName = "Tarianyk",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("2adfb17b-aaa2-48f7-aad2-5f5eb3bb4f10"),
                    Email = "bsolomon@cazcreek.com",
                    FirstName = "Barry",
                    LastName = "Solomon",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("47162c6b-fca9-4a00-a924-f29623aea49a"),
                    Email = "adinh@cazcreek.com",
                    FirstName = "Andy",
                    LastName = "Dinh",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("6cfcb24f-a6af-4ce4-8d58-9a11efb0fe60"),
                    Email = "olialka@corevalue.net",
                    FirstName = "Oleksandr",
                    LastName = "Lialka",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("1529f9e0-cb28-4c3a-b577-369ef8769e85"),
                    Email = "frank.soto@huntcompanies.com",
                    FirstName = "Frank",
                    LastName = "Soto",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("2c355360-394c-4fca-b9fe-517f0732ebb0"),
                    Email = "ovoronin@corevalue.net",
                    FirstName = "Oleg",
                    LastName = "Voronin",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("4f88a9ea-132b-4d20-a3e1-17f42f778ea3"),
                    Email = "oshumyn@corevalue.net",
                    FirstName = "Ostap",
                    LastName = "Shumyn",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("bbaf6db6-c66e-427a-b0fe-15dc6c9a2754"),
                    Email = "mkobryn@corevalue.net",
                    FirstName = "Mykhailo",
                    LastName = "Kobryn",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
                new User
                {
                    Id = new Guid("04a1a2c2-9897-453a-ad82-88b865e2273a"),
                    Email = "sshykerynets@corevalue.net",
                    FirstName = "Stepan",
                    LastName = "Shykerynets",
                    CreatedById = systemUser,
                    CreatedOn = DateTime.Now,
                    ModifiedById = systemUser,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                },
            };
        }
    }
}
