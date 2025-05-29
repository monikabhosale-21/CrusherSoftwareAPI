using System;
using System.Collections.Generic;
using CrusherSoftwareAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CrusherSoftwareAPI.Data;

public partial class CrusherDbContext : DbContext
{
    private readonly IConfiguration _configuration;

     
    
    public CrusherDbContext(DbContextOptions<CrusherDbContext> options, IConfiguration configuration)
       : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<DieselEntry> DieselEntries { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PetrolPump> PetrolPumps { get; set; }

    public virtual DbSet<Quatation> Quatations { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TripSelection> TripSelections { get; set; }

    //public virtual DbSet<Type> Types { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-145FM2A;Database=CrusherSoftware;User Id=sa;Password=admin@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress).HasMaxLength(200);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.OpeningDues).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DieselEntry>(entity =>
        {
            entity.ToTable("DieselEntry");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Diesel_Petrol)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Diesel/Petrol");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.PetrolPump).HasMaxLength(100);
            entity.Property(e => e.Reading).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vehicle).HasMaxLength(100);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Login");

            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.ToTable("Material");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MaterialName).HasMaxLength(50);
            entity.Property(e => e.MaterialType_Sale_purchase_)
                .HasMaxLength(100)
                .HasColumnName("MaterialType(Sale purchase)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.ToTable("Owner");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dues).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.OwnerName).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PetrolPump>(entity =>
        {
            entity.ToTable("PetrolPump");

            entity.Property(e => e.PetrolPumpId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Opening_Payable).HasMaxLength(50);
            entity.Property(e => e.PetrolPumpName).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Quatation>(entity =>
        {
            entity.ToTable("Quatation");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Contact_No).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.Material_Name)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Qt_Date).HasColumnType("datetime");
            entity.Property(e => e.Reference)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.TripSelection).HasMaxLength(100);
            entity.Property(e => e.Unit).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier");

            entity.Property(e => e.SupplierId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Opening_Payable).HasMaxLength(50);
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.Supplier_Address)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TripSelection>(entity =>
        {
            entity.ToTable("TripSelection");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.TripSelectionName).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        //modelBuilder.Entity<Type>(entity =>
        //{
        //    entity.ToTable("Type");

        //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        //    entity.Property(e => e.TypeName).HasMaxLength(50);
        //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        //});

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.ToTable("Unit");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UnitName).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.ToTable("Vehicle");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Emptyweight).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VehicleNo).HasMaxLength(50);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.ToTable("Vendor");

            entity.Property(e => e.VendorId).ValueGeneratedNever();
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Opening_Payable).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
