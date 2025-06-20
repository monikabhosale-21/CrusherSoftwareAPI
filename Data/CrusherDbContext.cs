using System;
using System.Collections.Generic;
using CrusherSoftwareAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrusherSoftwareAPI.Data;

public partial class CrusherDbContext : DbContext
{
    public CrusherDbContext()
    {
    }

    public CrusherDbContext(DbContextOptions<CrusherDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CreditNote> CreditNotes { get; set; }

    public virtual DbSet<CrushCategory> CrushCategories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerPayment> CustomerPayments { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<Maintenance> Maintenances { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<OwnerVehicle> OwnerVehicles { get; set; }

    public virtual DbSet<PetrolPump> PetrolPumps { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<PumpDieselEntry> PumpDieselEntries { get; set; }

    public virtual DbSet<PumpPayment> PumpPayments { get; set; }

    public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }

    public virtual DbSet<PurchaseMaster> PurchaseMasters { get; set; }

    public virtual DbSet<PurchasePayment> PurchasePayments { get; set; }

    public virtual DbSet<PurchaseVehicle> PurchaseVehicles { get; set; }

    public virtual DbSet<QuotationDetail> QuotationDetails { get; set; }

    public virtual DbSet<QuotationMaster> QuotationMasters { get; set; }

    public virtual DbSet<QuotationTerm> QuotationTerms { get; set; }

    public virtual DbSet<SaleDetail> SaleDetails { get; set; }

    public virtual DbSet<SaleMaster> SaleMasters { get; set; }

    public virtual DbSet<SalePayment> SalePayments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<VendorPayment> VendorPayments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-145FM2A;Database=CrusherDB;User Id=sa;Password=admin@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Cat_Id).HasName("PK__Category__26E35140C31A4873");

            entity.ToTable("Category", "CrusherSchema");

            entity.Property(e => e.Category_Name).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__F2D21B7620BA9100");

            entity.ToTable("City", "CrusherSchema");

            entity.Property(e => e.CityName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CreditNote>(entity =>
        {
            entity.HasKey(e => e.Credit_Note_Id).HasName("PK__CreditNo__82F5F6A505B72794");

            entity.ToTable("CreditNote", "CrusherSchema");

            entity.Property(e => e.AC_Type).HasMaxLength(20);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Credit_Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Credit_Date).HasColumnType("datetime");
            entity.Property(e => e.Credit_Desc).HasMaxLength(500);
            entity.Property(e => e.Cust_Mobile).HasMaxLength(20);
            entity.Property(e => e.Due_Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Due_Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HSN_No).HasMaxLength(50);
            entity.Property(e => e.Invoice_No).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Prod_Name).HasMaxLength(100);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Reason).HasMaxLength(250);
            entity.Property(e => e.Tax_Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax_Rate)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vend_Mobile).HasMaxLength(20);
        });

        modelBuilder.Entity<CrushCategory>(entity =>
        {
            entity.HasKey(e => e.Cat_Id).HasName("PK__CrushCat__26E3514006C10CC3");

            entity.ToTable("CrushCategory", "CrusherSchema");

            entity.Property(e => e.Category_Name).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer", "CrusherSchema");

            entity.Property(e => e.CityName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerAddress).HasMaxLength(200);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Mobile).HasMaxLength(100);
            entity.Property(e => e.OpeningDues).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerPayment>(entity =>
        {
            entity.HasKey(e => e.Cust_Pay_Id).HasName("PK__Customer__A73F2A848B8953B2");

            entity.ToTable("CustomerPayment", "CrusherSchema");

            entity.Property(e => e.Chk_Date).HasColumnType("datetime");
            entity.Property(e => e.Chk_No).HasMaxLength(50);
            entity.Property(e => e.Cust_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cust_Name).HasMaxLength(100);
            entity.Property(e => e.Cust_Pay_Date).HasColumnType("datetime");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pay_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pay_Desc).HasMaxLength(300);
            entity.Property(e => e.Pay_For).HasMaxLength(200);
            entity.Property(e => e.Pay_Mode).HasMaxLength(50);
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Exp_Id).HasName("PK__Expense__3E4B09B18250537B");

            entity.ToTable("Expense", "CrusherSchema");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Exp_Date).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Maintenance>(entity =>
        {
            entity.HasKey(e => e.Maintenance_Id).HasName("PK__Maintena__CCC49F7F3A1973D8");

            entity.ToTable("Maintenance", "CrusherSchema");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Due_Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Maintenance_Date).HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Own_Id).HasName("PK__Owner__2267B14A8D3CC8B1");

            entity.ToTable("Owner", "CrusherSchema");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Own_City).HasMaxLength(100);
            entity.Property(e => e.Own_Due)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Own_Email).HasMaxLength(150);
            entity.Property(e => e.Own_Mobile).HasMaxLength(20);
            entity.Property(e => e.Own_Name).HasMaxLength(150);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vehicle_No).HasMaxLength(50);
        });

        modelBuilder.Entity<OwnerVehicle>(entity =>
        {
            entity.HasKey(e => e.Own_Vehi_Id).HasName("PK__OwnerVeh__05549E446AD1D130");

            entity.ToTable("OwnerVehicle", "CrusherSchema");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vehicle_No).HasMaxLength(50);

            entity.HasOne(d => d.Own).WithMany(p => p.OwnerVehicles)
                .HasForeignKey(d => d.Own_Id)
                .HasConstraintName("FK_OwnerVehicle_Owner");
        });

        modelBuilder.Entity<PetrolPump>(entity =>
        {
            entity.HasKey(e => e.Pump_Id).HasName("PK__PetrolPu__8834C94AD85E41E4");

            entity.ToTable("PetrolPump", "CrusherSchema");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Open_Due)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Prod_Id);

            entity.ToTable("Product", "CrusherSchema");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Prod_Name).HasMaxLength(100);
            entity.Property(e => e.Prod_Type).HasMaxLength(100);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PumpDieselEntry>(entity =>
        {
            entity.HasKey(e => e.Pump_Diesel_Id).HasName("PK__PumpDies__5CA709935589DD98");

            entity.ToTable("PumpDieselEntry", "CrusherSchema");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Diesel).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Diesel_Date).HasColumnType("datetime");
            entity.Property(e => e.Due_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Due_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Reading).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vehicle_No).HasMaxLength(50);
        });

        modelBuilder.Entity<PumpPayment>(entity =>
        {
            entity.HasKey(e => e.Pump_Pay_Id).HasName("PK__PumpPaym__196264F51ED118B1");

            entity.ToTable("PumpPayment", "CrusherSchema");

            entity.Property(e => e.Chk_Date).HasColumnType("datetime");
            entity.Property(e => e.Chk_No).HasMaxLength(50);
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Pay_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pay_Desc).HasMaxLength(300);
            entity.Property(e => e.Pay_For).HasMaxLength(200);
            entity.Property(e => e.Pay_Mode).HasMaxLength(50);
            entity.Property(e => e.Pump_Pay_Date).HasColumnType("datetime");
            entity.Property(e => e.Vend_Due).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PurchaseDetail>(entity =>
        {
            entity.HasKey(e => e.PurdId).HasName("PK__Purchase__CF60D1F80D971464");

            entity.ToTable("PurchaseDetail", "CrusherSchema");

            entity.Property(e => e.Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DiscAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmptyWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Morang).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProdName).HasMaxLength(100);
            entity.Property(e => e.Qnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);

            entity.HasOne(d => d.Purm).WithMany(p => p.PurchaseDetails)
                .HasForeignKey(d => d.PurmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PurchaseD__PurmI__6477ECF3");
        });

        modelBuilder.Entity<PurchaseMaster>(entity =>
        {
            entity.HasKey(e => e.PurmId).HasName("PK__Purchase__CD266799EFF31E52");

            entity.ToTable("PurchaseMaster", "CrusherSchema");

            entity.Property(e => e.BillType).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Diesel)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DueAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EmpRent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalDue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.PreDue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PurFrom).HasMaxLength(150);
            entity.Property(e => e.PurmDate).HasColumnType("datetime");
            entity.Property(e => e.PurmTime).HasMaxLength(20);
            entity.Property(e => e.RecAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefNo).HasMaxLength(100);
            entity.Property(e => e.Remark).HasMaxLength(500);
            entity.Property(e => e.Rent)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RoyInv).HasMaxLength(50);
            entity.Property(e => e.RoyaltyNo).HasMaxLength(50);
            entity.Property(e => e.TaxableAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VendMobile).HasMaxLength(20);
        });

        modelBuilder.Entity<PurchasePayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__Purchase__9B556A3809691D9E");

            entity.ToTable("PurchasePayment", "CrusherSchema");

            entity.Property(e => e.ChkDate).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PayMode).HasMaxLength(50);

            entity.HasOne(d => d.Purm).WithMany(p => p.PurchasePayments)
                .HasForeignKey(d => d.PurmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PurchaseP__PurmI__693CA210");
        });

        modelBuilder.Entity<PurchaseVehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Purchase__476B549277A0F33A");

            entity.ToTable("PurchaseVehicle", "CrusherSchema");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmptyWeight).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Morang).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehicleNo).HasMaxLength(50);

            entity.HasOne(d => d.Purm).WithMany(p => p.PurchaseVehicles)
                .HasForeignKey(d => d.PurmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PurchaseV__PurmI__6D0D32F4");
        });

        modelBuilder.Entity<QuotationDetail>(entity =>
        {
            entity.HasKey(e => e.Quod_Id).HasName("PK__Quotatio__43B2FA2698A97449");

            entity.ToTable("QuotationDetail", "CrusherSchema");

            entity.Property(e => e.Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Enq_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Enq_Tax_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Enq_Taxable_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Enq_Taxble_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Enq_Tot_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Prod_Name).HasMaxLength(100);
            entity.Property(e => e.Qnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax_Rate).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Taxble_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tot_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Quom).WithMany(p => p.QuotationDetails)
                .HasForeignKey(d => d.Quom_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationDetail_Master");
        });

        modelBuilder.Entity<QuotationMaster>(entity =>
        {
            entity.HasKey(e => e.Quom_Id).HasName("PK__Quotatio__6CE68211EC44DBF1");

            entity.ToTable("QuotationMaster", "CrusherSchema");

            entity.Property(e => e.Bill_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Cust_City).HasMaxLength(100);
            entity.Property(e => e.Cust_Mobile).HasMaxLength(20);
            entity.Property(e => e.Cust_Name).HasMaxLength(150);
            entity.Property(e => e.Diesel)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Disc_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Disc_Qua).HasMaxLength(50);
            entity.Property(e => e.Due_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Final_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.Pre_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Quo_Date).HasColumnType("datetime");
            entity.Property(e => e.Quo_No).HasMaxLength(50);
            entity.Property(e => e.Rec_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ref_Name).HasMaxLength(100);
            entity.Property(e => e.Ref_No).HasMaxLength(100);
            entity.Property(e => e.Rent)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taxable_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Term_Flag).HasDefaultValue(false);
            entity.Property(e => e.Trip_Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vehi_No).HasMaxLength(50);
        });

        modelBuilder.Entity<QuotationTerm>(entity =>
        {
            entity.HasKey(e => e.Term_Id).HasName("PK__Quotatio__C51E8C419F6B4671");

            entity.ToTable("QuotationTerms", "CrusherSchema");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Quom).WithMany(p => p.QuotationTerms)
                .HasForeignKey(d => d.Quom_Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationTerms_Master");
        });

        modelBuilder.Entity<SaleDetail>(entity =>
        {
            entity.HasKey(e => e.BdId).HasName("PK__SaleDeta__49F641194D377EEE");

            entity.ToTable("SaleDetail", "CrusherSchema");

            entity.Property(e => e.Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Disc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscMode).HasMaxLength(10);
            entity.Property(e => e.EmptyWt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ProdName).HasMaxLength(100);
            entity.Property(e => e.Pump).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Qnty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalWt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Transport).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Bm).WithMany(p => p.SaleDetails)
                .HasForeignKey(d => d.BmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaleDetail_SaleMaster");
        });

        modelBuilder.Entity<SaleMaster>(entity =>
        {
            entity.HasKey(e => e.BmId).HasName("PK__SaleMast__53B449DDC3D1445A");

            entity.ToTable("SaleMaster", "CrusherSchema");

            entity.Property(e => e.BillAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BmDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustMobile).HasMaxLength(20);
            entity.Property(e => e.CustName).HasMaxLength(150);
            entity.Property(e => e.Diesel)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscBy).HasMaxLength(100);
            entity.Property(e => e.DriverMo).HasMaxLength(20);
            entity.Property(e => e.DriverNm).HasMaxLength(100);
            entity.Property(e => e.DueAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalAmt1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalDue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalDue1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InvoiceNo).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.LabourAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Location).HasMaxLength(100);
            entity.Property(e => e.PreDue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PumpAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PurCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RecAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefName).HasMaxLength(100);
            entity.Property(e => e.RefNo).HasMaxLength(100);
            entity.Property(e => e.Rent)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RoyInv).HasMaxLength(50);
            entity.Property(e => e.RoyaltyNo).HasMaxLength(50);
            entity.Property(e => e.SaleMode).HasMaxLength(50);
            entity.Property(e => e.TaxCharge).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotPump).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VehiNo).HasMaxLength(50);
            entity.Property(e => e.WaitCharge).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SalePayment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__SalePaym__9B556A383D93DBBB");

            entity.ToTable("SalePayment", "CrusherSchema");

            entity.Property(e => e.ChkDate).HasColumnType("datetime");
            entity.Property(e => e.ChkNo).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PayMode).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Bm).WithMany(p => p.SalePayments)
                .HasForeignKey(d => d.BmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalePayment_SaleMaster");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC079BCAF8F2");

            entity.ToTable("Users", "CrusherSchema");

            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasDefaultValue("User");
            entity.Property(e => e.Username).HasMaxLength(100);
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vehicle_Id).HasName("PK__Vehicle__CE6D7C9500BE156C");

            entity.ToTable("Vehicle", "CrusherSchema");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Empty_Weight).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Vehicle_No).HasMaxLength(50);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.VendId).HasName("PK__Vendor__42ABCAC5810E06A2");

            entity.ToTable("Vendor", "CrusherSchema");

            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GSTNo).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.VendName).HasMaxLength(150);
        });

        modelBuilder.Entity<VendorPayment>(entity =>
        {
            entity.HasKey(e => e.Vend_Pay_Id).HasName("PK__VendorPa__35CD37C8FB4A9BD6");

            entity.ToTable("VendorPayment", "CrusherSchema");

            entity.Property(e => e.Chk_Date).HasColumnType("datetime");
            entity.Property(e => e.Chk_No).HasMaxLength(50);
            entity.Property(e => e.Final_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pay_Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pay_Desc).HasMaxLength(300);
            entity.Property(e => e.Pay_For).HasMaxLength(200);
            entity.Property(e => e.Pay_Mode).HasMaxLength(50);
            entity.Property(e => e.Vend_Due).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vend_Name).HasMaxLength(100);
            entity.Property(e => e.Vend_Pay_Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
