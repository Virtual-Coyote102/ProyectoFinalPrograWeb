using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Diente_Fuerte.Models.dbModels;

public partial class DienteFuerteContext : IdentityDbContext<ApplicationUser,IdentityRole<int>,int>
{
    public DienteFuerteContext()
    {
    }

    public DienteFuerteContext(DbContextOptions<DienteFuerteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Calificacione> Calificaciones { get; set; }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Dia> Dias { get; set; }

    public virtual DbSet<Expediente> Expedientes { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Reporte> Reportes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Calificacione>(entity =>
        {
            entity.HasKey(e => e.IdCalificacion).HasName("PK__Califica__40E4A7516388F61D");

            entity.Property(e => e.IdCalificacion).ValueGeneratedNever();
        });

        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.IdCita).HasName("PK__Citas__394B02026D0B393A");

            entity.Property(e => e.IdCita).ValueGeneratedNever();

            entity.HasOne(d => d.CurpIdClienteNavigation).WithMany(p => p.Cita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Citas__CURP_IdCl__4222D4EF");

            entity.HasOne(d => d.FechaSolicitadaNavigation).WithMany(p => p.Cita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Citas__FechaSoli__4316F928");

            entity.HasOne(d => d.HoraSolicitadaNavigation).WithMany(p => p.Cita)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Citas__HoraSolic__440B1D61");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CurpIdCliente).HasName("PK__Clientes__1225D6FA45966444");

            entity.HasOne(d => d.ServicioNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clientes__Servic__3F466844");
        });

        modelBuilder.Entity<Dia>(entity =>
        {
            entity.HasKey(e => e.IdDias).HasName("PK__Dias__F168F64119162CE7");

            entity.Property(e => e.IdDias).ValueGeneratedNever();
        });

        modelBuilder.Entity<Expediente>(entity =>
        {
            entity.HasKey(e => e.IdArchivo).HasName("PK__Expedien__26B92111FACF8E2E");

            entity.Property(e => e.IdArchivo).ValueGeneratedNever();

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Expedientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Expedient__IdCli__46E78A0C");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHora).HasName("PK__Horarios__5FEB39EB2AA50FB6");

            entity.Property(e => e.IdHora).ValueGeneratedNever();
        });

        modelBuilder.Entity<Reporte>(entity =>
        {
            entity.HasKey(e => e.IdReporte).HasName("PK__Reportes__F9561136386DFB4A");

            entity.Property(e => e.IdReporte).ValueGeneratedNever();

            entity.HasOne(d => d.FinNavigation).WithMany(p => p.ReporteFinNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reportes__Fin__49C3F6B7");

            entity.HasOne(d => d.InicioNavigation).WithMany(p => p.ReporteInicioNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reportes__Inicio__4AB81AF0");

            entity.HasOne(d => d.ServicioNavigation).WithMany(p => p.Reportes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reportes__Servic__4BAC3F29");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Roles__2A49584CE98623EC");

            entity.Property(e => e.IdRol).ValueGeneratedNever();
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__2DCCF9A2DF295F1C");

            entity.Property(e => e.IdServicio).ValueGeneratedNever();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__5B65BF97E98BCBA2");

            entity.Property(e => e.IdUsuario).ValueGeneratedNever();

            entity.HasOne(d => d.RolUsuarioNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuarios__RolUsu__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
