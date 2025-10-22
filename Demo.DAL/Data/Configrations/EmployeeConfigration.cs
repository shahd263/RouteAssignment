using Demo.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data.Configrations
{
    internal class EmployeeConfigration : BaseEntityConfigration<Employee> , IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
           

            builder.Property(X=>X.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(X => X.Address).HasColumnType("varchar(150)");
            builder.Property(X => X.Email).HasColumnType("varchar(100)");
            builder.Property(X => X.PhoneNumber).HasColumnType("varchar(11)");
            builder.Property(X => X.Salary).HasColumnType("decimal(10,2)");

            builder.ToTable(Tb =>
            {
                Tb.HasCheckConstraint("EmployeeValidAgeCheck", "Age between 24 and 50");
                Tb.HasCheckConstraint("EmployeeValidEmailCheck" , "Email like  '_%@_%._%'");
            });

            base.Configure(builder);
        }
    }
}
