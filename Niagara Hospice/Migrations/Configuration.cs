namespace Niagara_Hospice.Migrations
{
    using Niagara_Hospice;
    using Niagara_Hospice.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NiagaraHospiceCFEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NiagaraHospiceCFEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //var users = new List<AspNetUsers>
            //{
            //    new User { FirstName = "Testuser", MiddleName = "N", LastName = "One", Type = "Staff", Subtype = "Admin", Email = "Testperson1@mail.lol", Phone = "1111111111", Address = "1 1st St", City = "St. Catharines" },
            //    new User { FirstName = "Testuser", MiddleName = "D", LastName = "Two", Type = "Board", Subtype = "Governance", Email = "Testperson2@mail.lol", Phone = "2222222222", Address = "2 2nd Ave", City = "Welland" },
            //    new User { FirstName = "Testuser", MiddleName = "W", LastName = "Three", Type = "Volunteer", Subtype = "Community", Email = "Testperson3@mail.lol", Phone = "3333333333", Address = "3 3rd Crt", City = "Thorold" }
            //};
            //users.ForEach(u => context.Users.AddOrUpdate(n => n.LastName, u));
            //context.SaveChanges();

            //var clients = new List<Client>
            //{
            //    new Client { FirstName = "Testclient", MiddleName = "E", LastName = "One", DOB = DateTime.Parse("1985-04-24"), Phone = "5555555555", Address = "46 Road St", City = "St. Catharines", Status = "Deceased" },
            //    new Client { FirstName = "Testclient", MiddleName = "G", LastName = "Two ", DOB = DateTime.Parse("1949-12-22"), Phone = "6666666666", Address = "412 Green St", City = "Grimsby", Status = "In Care" },
            //    new Client { FirstName = "Robert", MiddleName = "", LastName = "Thomas", DOB = DateTime.Parse("1990-08-16"), Phone = "7777777777", Address = "808 Snare Drum", City = "Thorold", Status = "Ballin'" }
            //};
            //clients.ForEach(c => context.Clients.AddOrUpdate(n => n.LastName, c));
            //context.SaveChanges();

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
