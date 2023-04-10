using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Desktop.Models;

public partial class PlanetConfigContext : DbContext
{
    public PlanetConfigContext()
    {
    }

    public PlanetConfigContext(DbContextOptions<PlanetConfigContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DataFile> DataFiles { get; set; }

    public virtual DbSet<Planet> Planets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=C:\\Dev\\Projects\\Gaming\\CD-i\\Laser Lords Content\\LaserLordsDataMapper\\planetConfigs.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DataFile>(entity =>
        {
            entity.ToTable("data_files");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.DyuvOffset).HasColumnName("dyuv_offset");
            entity.Property(e => e.HasDyuv).HasColumnName("has_dyuv");
            entity.Property(e => e.HasScreen).HasColumnName("has_screen");
            entity.Property(e => e.HasSprites).HasColumnName("has_sprites");
            entity.Property(e => e.HasText).HasColumnName("has_text");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PlanetId).HasColumnName("planet_id");
            entity.Property(e => e.SpriteData).HasColumnName("sprite_data");
            entity.Property(e => e.TextOffset).HasColumnName("text_offset");

            entity.HasOne(d => d.Planet).WithMany(p => p.DataFiles).HasForeignKey(d => d.PlanetId);
        });

        modelBuilder.Entity<Planet>(entity =>
        {
            entity.ToTable("planets");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
