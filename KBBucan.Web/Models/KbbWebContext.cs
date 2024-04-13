using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KBBucan.Web.Models;

public partial class KbbWebContext : DbContext
{
    public KbbWebContext()
    {
    }

    public KbbWebContext(DbContextOptions<KbbWebContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IletisimFormu> IletisimFormus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2C6E5LJ;Database=KbbWeb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IletisimFormu>(entity =>
        {
            entity.HasKey(e => e.MesajId);

            entity.ToTable("IletisimFormu");

            entity.Property(e => e.MesajId).HasColumnName("MesajID");
            entity.Property(e => e.AdSoyad)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Konu)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MailAdres)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Mesaj).IsUnicode(false);
            entity.Property(e => e.ProjeButcesi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonNumarasi)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
