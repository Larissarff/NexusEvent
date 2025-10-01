using Microsoft.EntityFrameworkCore;
using NexusEventBack.Models;
using System.Linq.Expressions;

namespace NexusEventBack.Data
{
    public class NexusDbContext : DbContext
    {
        public NexusDbContext(DbContextOptions<NexusDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<UserModel> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Name)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.HasIndex(u => u.Email).IsUnique();

                entity.Property(u => u.Role).HasConversion<int>();
                entity.Property(u => u.Status).HasConversion<int>();
            });

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(RegisterModel).IsAssignableFrom(entityType.ClrType))
                {
                    var method = typeof(EF).GetMethod("Property")!.MakeGenericMethod(typeof(bool));
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var property = Expression.Call(method, parameter, Expression.Constant("IsDeleted"));
                    var compare = Expression.Equal(property, Expression.Constant(false));
                    var lambda = Expression.Lambda(compare, parameter);

                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(lambda);
                }
            }
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<RegisterModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.UtcNow;
                        entry.Entity.UpdatedAt = DateTime.UtcNow;
                        entry.Entity.IsDeleted = false;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
