using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectMyDoc_Domain_Layer.Entity;
using Microsoft.EntityFrameworkCore;

namespace ConnectMyDoc_Data_Layer.Context
{
    public class PatientCMDDbContext : DbContext
    {
      
        public PatientCMDDbContext()
        {
        }


        public PatientCMDDbContext(DbContextOptions<PatientCMDDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PatientCMDDb;Integrated Security=True;Encrypt=True ");
            }
        }


        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientAddress> PatientAddresses { get; set; }

        public DbSet<HealthCondition> HealthConditions { get; set; }


    }
}
