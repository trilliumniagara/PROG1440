using Niagara_Hospice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Niagara_Hospice
{
    public class NiagaraHospiceCFEntities : DbContext
    {
        public NiagaraHospiceCFEntities() : base ("name=NiagaraHospiceCFEntities")
        {
        }
        public DbSet<AspNetSubRoles> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Announcements> Announcements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}