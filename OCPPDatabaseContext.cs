using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCPPServer
{
    public class OCPPDatabaseContext : DbContext
    {
        public OCPPDatabaseContext(DbContextOptions<OCPPDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Models.OCPPRequest> OCPPRequests { get; set; }
        public DbSet<Models.OCPPResponse> OCPPResponses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OCPPDatabase.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.OCPPRequest>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<Models.OCPPResponse>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NULL");
            });
        }
    }
}