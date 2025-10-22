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
    internal class DepartmentConfigration : BaseEntityConfigration<Department>, IEntityTypeConfiguration<Department> 
    {
        public new void Configure(EntityTypeBuilder<Department> builder)
        {
            

            builder.Property(X => X.Name).HasColumnType("varchar(20)");
            builder.Property(X => X.Description).HasColumnType("varchar(100)");
            builder.Property(X => X.Code).HasColumnType("varchar(20)");   
            
            base.Configure(builder);

        }
    }
}
