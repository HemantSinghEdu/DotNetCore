using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace testproject01.Entities
{
    public partial class TestDbContext : DbContext
    {
        public virtual DbSet<Film> Film { get; set; }
        
        public TestDbContext(DbContextOptions<TestDbContext> options)
                :base(options)
        {
                    
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                throw new Exception("Connection string for TestDbContext is not configured");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(256);
            });
        }
    }
}
