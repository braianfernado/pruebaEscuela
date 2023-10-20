using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Models;

public partial class DbescuelaContext : DbContext
{
    public DbescuelaContext()
    {
    }

    public DbescuelaContext(DbContextOptions<DbescuelaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<EstudiantesMateria> EstudiantesMaterias { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Profesore> Profesores { get; set; }




    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteId).HasName("PK__Estudian__6F768338BF774A48");

            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<EstudiantesMateria>(entity =>
        {
            entity.HasKey(e => new { e.EstudianteId, e.MateriaId }).HasName("PK__Estudian__6FA69AE0F6D89A89");

            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.MateriaId).HasColumnName("MateriaID");
            entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

            entity.HasOne(d => d.EstudianteidNavigation).WithMany(p => p.EstudiantesMateria)
                .HasForeignKey(d => d.EstudianteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Estud__30F848ED");

            entity.HasOne(d => d.MateriaidNavigation).WithMany(p => p.EstudiantesMateria)
                .HasForeignKey(d => d.MateriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Mater__31EC6D26");

            entity.HasOne(d => d.MateriaidNavigation).WithMany(p => p.EstudiantesMateria)
                .HasForeignKey(d => d.ProfesorId)
                .HasConstraintName("FK__Estudiant__Profe__32E0915F");
        });

        modelBuilder.Entity<Materia>(entity =>
        {
            entity.HasKey(e => e.MateriaId).HasName("PK__Materias__0D019D818F364255");

            entity.Property(e => e.MateriaId).HasColumnName("MateriaID");
            entity.Property(e => e.NombreMateria).HasMaxLength(100);
        });

        modelBuilder.Entity<Profesore>(entity =>
        {
            entity.HasKey(e => e.ProfesorId).HasName("PK__Profesor__4DF3F028FBA9AB1E");

            entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
