using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestQuest.Model
{
    internal class RealEstateContext :DbContext
    {

        
        public virtual DbSet<PropertyImage> PropertyImages { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        
        public virtual DbSet<User> Users { get; set; }
       public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=RealEstate;Trusted_Connection=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().HasKey(t => new { t.ClientId, t.PropertyId });
            base.OnModelCreating(modelBuilder);
           
        }


    }
}
