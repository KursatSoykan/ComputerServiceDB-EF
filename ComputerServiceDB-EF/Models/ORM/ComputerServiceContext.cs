using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceDB_EF.Models.ORM
{
    public class ComputerServiceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KKUKD45\\SQLEXPRESS01;Database=ComputerServiceDB-EF;Trusted_Connection=true;TrustServerCertificate=true;");

        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<ServiceStatus> ServiceStatus { get; set; }
        public DbSet<ServiceRecords> ServiceRecords { get; set; }
        public DbSet<SpareParts> SpareParts { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
    }
}
