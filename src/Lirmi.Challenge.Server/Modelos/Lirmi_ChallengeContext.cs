using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lirmi.Challenge.Server.Modelos
{
    public partial class Lirmi_ChallengeContext : DbContext
    {
        public Lirmi_ChallengeContext()
        {
        }

        public Lirmi_ChallengeContext(DbContextOptions<Lirmi_ChallengeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignatura> Asignaturas { get; set; } = null!;
        public virtual DbSet<Colegio> Colegios { get; set; } = null!;
        public virtual DbSet<Curso> Cursos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignatura>(entity =>
            {
                entity.HasKey(e => e.IdAsignatura)
                    .HasName("PK__Asignatu__FAE056831329AB64");

                entity.ToTable("Asignatura");

                entity.Property(e => e.IdAsignatura).HasColumnName("Id_Asignatura");

                entity.Property(e => e.NombreAsignatura)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Asignatura");
            });

            modelBuilder.Entity<Colegio>(entity =>
            {
                entity.HasKey(e => e.IdColegio)
                    .HasName("PK__Colegio__B04AB08524FF29F1");

                entity.ToTable("Colegio");

                entity.Property(e => e.IdColegio).HasColumnName("Id_Colegio");

                entity.Property(e => e.IdCurso).HasColumnName("Id_Curso");

                entity.Property(e => e.NombreColegio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Colegio");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.Colegios)
                    .HasForeignKey(d => d.IdCurso)
                    .HasConstraintName("FK__Colegio__Id_Curs__29572725");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PK__Curso__A40D2A883BD928E3");

                entity.ToTable("Curso");

                entity.Property(e => e.IdCurso).HasColumnName("Id_Curso");

                entity.Property(e => e.IdAsignatura).HasColumnName("Id_Asignatura");

                entity.Property(e => e.NombreCurso)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Curso");

                entity.HasOne(d => d.IdAsignaturaNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdAsignatura)
                    .HasConstraintName("FK__Curso__Id_Asigna__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
