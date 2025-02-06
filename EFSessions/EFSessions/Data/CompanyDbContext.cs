using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFSessions.Data.Models;
using Microsoft.EntityFrameworkCore;
using FluentApis;
using EFSessions.Data.Configurations;
using System.Reflection;
namespace EFSessions.Data
{
    internal class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UFFGN5G;Database=Company;Trusted_Connection=True;Trustservercertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Employee
            //// Fluent Apis for each and every model
            //// used if by convention and data annotation cant do what you want or if you dont
            //// have the source code
            //// Main use in relations
            //modelBuilder.Entity<Employee>()
            //    .Property<string>("Address")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .IsRequired();
            ////modelBuilder.Entity<Employee>().Property(E => E.Name); 
            #endregion
            #region Department
            //modelBuilder.Entity<Department>().HasKey(nameof(Department.DeptId));
            //modelBuilder.Entity<Department>().Property(D => D.DeptId).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Department>().Property(D => D.Name)
            //    .HasColumnName("DeptName")
            //    .HasColumnType("varchar")
            //    .IsRequired();
            //modelBuilder.Entity<Department>().Property(D => D.CreationDate)
            //    .HasDefaultValueSql("GETDATE()");
            //modelBuilder.Entity<Department>().ToTable("Departments", "dbo"); // Not prefered
            #endregion
            //modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());
            //// we are repeating!!
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // applies all configs
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments {  get; set; }
    }
}
