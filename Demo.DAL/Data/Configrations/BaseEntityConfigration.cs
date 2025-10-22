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
    internal class BaseEntityConfigration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(X => X.LastModifiedAt).HasComputedColumnSql("GETDATE()");
            builder.Property(X => X.IsDeleted).HasDefaultValue(false);
        }
    }
}
