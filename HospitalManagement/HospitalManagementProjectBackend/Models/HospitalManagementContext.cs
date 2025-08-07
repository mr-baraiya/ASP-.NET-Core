using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementProject.Models;

public partial class HospitalManagementContext : DbContext
{
    public HospitalManagementContext()
    {
    }

    public HospitalManagementContext(DbContextOptions<HospitalManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<HospitalMaster> HospitalMasters { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__2DC00EDF88C59048");

            entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            entity.Property(e => e.Degree).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.DoctorName).HasMaxLength(150);
            entity.Property(e => e.Specification).HasMaxLength(50);
        });

        modelBuilder.Entity<HospitalMaster>(entity =>
        {
            entity.HasKey(e => e.HospitalId).HasName("PK__Hospital__38C2E58F11C1B45C");

            entity.ToTable("HospitalMaster");

            entity.Property(e => e.HospitalId).HasColumnName("HospitalID");
            entity.Property(e => e.ContactNumber).HasMaxLength(10);
            entity.Property(e => e.EmailAddress).HasMaxLength(250);
            entity.Property(e => e.HospitalAddress).HasMaxLength(250);
            entity.Property(e => e.HospitalName).HasMaxLength(150);
            entity.Property(e => e.OpeningDate).HasColumnType("datetime");
            entity.Property(e => e.OwnerName).HasMaxLength(250);
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).HasName("PK__Patients__970EC346BDB78FBB");

            entity.Property(e => e.PatientId).HasColumnName("PatientID");
            entity.Property(e => e.BloodGroup).HasMaxLength(10);
            entity.Property(e => e.Contact).HasMaxLength(10);
            entity.Property(e => e.PatientName).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
