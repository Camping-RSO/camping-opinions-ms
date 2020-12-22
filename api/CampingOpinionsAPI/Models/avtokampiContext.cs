using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CampingOpinionsAPI.Models
{
    public partial class avtokampiContext : DbContext
    {
        public avtokampiContext()
        {
        }

        public avtokampiContext(DbContextOptions<avtokampiContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Mnenja> Mnenja { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mnenja>(entity =>
            {
                entity.HasKey(e => e.MnenjeId)
                    .HasName("mnenja_pkey");

                entity.ToTable("mnenja");

                entity.Property(e => e.MnenjeId)
                    .HasColumnName("mnenje_id");

                entity.Property(e => e.Avtokamp).HasColumnName("avtokamp");

                entity.Property(e => e.Mnenje)
                    .HasColumnName("mnenje")
                    .HasMaxLength(1000);

                entity.Property(e => e.Ocena).HasColumnName("ocena");

                entity.Property(e => e.Uporabnik).HasColumnName("uporabnik");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
