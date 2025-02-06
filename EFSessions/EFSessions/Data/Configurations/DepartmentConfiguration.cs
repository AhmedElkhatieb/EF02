using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EFSessions.Data.Models;
using FluentApis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFSessions.Data.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(nameof(Department.DeptId));
            builder.Property(D => D.DeptId).UseIdentityColumn(10, 10);
            builder.Property(D => D.Name)
                .HasColumnName("DeptName")
                .HasColumnType("varchar")
                .IsRequired();
            builder.Property(D => D.CreationDate)
                .HasDefaultValueSql("GETDATE()");
            builder.HasMany<Employee>("Employess")
                .WithOne(E => E.Department)
                .HasForeignKey(E => E.DeptId);
        }
        // After finishing we must go to dbcontext and applyconfiguration
    }
}
