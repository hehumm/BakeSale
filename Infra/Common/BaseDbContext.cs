using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Infra.Common
{
    public abstract class BaseDbContext<T> : DbContext where T : DbContext
    {
        protected BaseDbContext(DbContextOptions<T> options) : base(options)
        {
        }

        internal static void createPrimaryKey<TEntity>(ModelBuilder modelBuilder, string tableName,
            Expression<Func<TEntity, object>> primaryKey) where TEntity : class
        {
            modelBuilder.Entity<TEntity>()
                .ToTable(tableName)
                .HasKey(primaryKey);
        }

        internal static void createForeignKey<TEntity, TRelatedEntity>(ModelBuilder b,
            Expression<Func<TEntity, object>> foreignKey,
            Expression<Func<TEntity, TRelatedEntity>> entity, bool isOptional = false)
            where TEntity : class where TRelatedEntity : class
        {
            b.Entity<TEntity>()
                .HasOne(entity)
                .WithMany()
                .HasForeignKey(foreignKey)
                .OnDelete(isOptional ? DeleteBehavior.SetNull : DeleteBehavior.Restrict);
        }
    }
}