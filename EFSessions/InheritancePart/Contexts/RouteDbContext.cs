using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritancePart.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritancePart.Contexts
{
    internal class RouteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UFFGN5G;Database=RouteG01;Trusted_Connection=True;Trustservercertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();
            // TPH will map fulltime and parttime to one table [Employee]
            // Will add new column called discriminator
            #endregion
        }
        //public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        // Commented because in TPH we need only one table
        public DbSet<Employee> Employees { get; set; }
        // Now we have only one table to work with
        // if we did that or we kept 2 tables there will be no difference
    }
}
