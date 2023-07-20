using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Water_Invoices_Project.Models
{
    public partial class Water_InvoicesContext : DbContext
    {
        public Water_InvoicesContext()
        {
        }

        public Water_InvoicesContext(DbContextOptions<Water_InvoicesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NwcDefaultSliceValue> NwcDefaultSliceValues { get; set; }
        public virtual DbSet<NwcInvoice> NwcInvoices { get; set; }
        public virtual DbSet<NwcRrealEstateType> NwcRrealEstateTypes { get; set; }
        public virtual DbSet<NwcSubscriberFile> NwcSubscriberFiles { get; set; }
        public virtual DbSet<NwcSubscriptionFile> NwcSubscriptionFiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =DESKTOP-SFDKHS6\\SQLEXPRESS;Database=Water_Invoices;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<NwcDefaultSliceValue>(entity =>
            {
                entity.HasKey(e => e.NwcDefaultSliceValuesCode)
                    .HasName("PK__NWC_Defa__EF32EC00A5E2D6A4");

                entity.ToTable("NWC_Default_Slice_Values");

                entity.Property(e => e.NwcDefaultSliceValuesCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Default_Slice_Values_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcDefaultSliceValuesCondtion).HasColumnName("NWC_Default_Slice_Values_Condtion");

                entity.Property(e => e.NwcDefaultSliceValuesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Default_Slice_Values_Name");

                entity.Property(e => e.NwcDefaultSliceValuesReasons)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Default_Slice_Values_Reasons");

                entity.Property(e => e.NwcDefaultSliceValuesSanitationPrice)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("NWC_Default_Slice_Values_Sanitation_Price");

                entity.Property(e => e.NwcDefaultSliceValuesWaterPrice)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("NWC_Default_Slice_Values_Water_Price");
            });

            modelBuilder.Entity<NwcInvoice>(entity =>
            {
                entity.HasKey(e => e.NwcInvoicesNo)
                    .HasName("PK__NWC_Invo__0400398F005D7A6E");

                entity.ToTable("NWC_Invoices");

                entity.Property(e => e.NwcInvoicesNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Invoices_No")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcInvoicesAmountConsumption)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NWC_Invoices_Amount_Consumption");

                entity.Property(e => e.NwcInvoicesConsumptionValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Consumption_Value");

                entity.Property(e => e.NwcInvoicesCurrentConsumptionAmount)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NWC_Invoices_Current_Consumption_Amount");

                entity.Property(e => e.NwcInvoicesDate)
                    .HasColumnType("date")
                    .HasColumnName("NWC_Invoices_Date");

                entity.Property(e => e.NwcInvoicesFrom)
                    .HasColumnType("date")
                    .HasColumnName("NWC_Invoices_From");

                entity.Property(e => e.NwcInvoicesIsThereSanitation).HasColumnName("NWC_Invoices_Is_There_Sanitation");

                entity.Property(e => e.NwcInvoicesPreviousConsumptionAmount)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NWC_Invoices_Previous_Consumption_Amount");

                entity.Property(e => e.NwcInvoicesRrealEstateTypes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Invoices_Rreal_Estate_Types")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcInvoicesServiceFee)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Service_Fee");

                entity.Property(e => e.NwcInvoicesSubscriberNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Invoices_Subscriber_No")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcInvoicesSubscriptionNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Invoices_Subscription_No")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcInvoicesTaxRate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Tax_Rate");

                entity.Property(e => e.NwcInvoicesTaxValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Tax_Value");

                entity.Property(e => e.NwcInvoicesTo)
                    .HasColumnType("date")
                    .HasColumnName("NWC_Invoices_To");

                entity.Property(e => e.NwcInvoicesTotalBill)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Total_Bill");

                entity.Property(e => e.NwcInvoicesTotalInvoice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Total_Invoice");

                entity.Property(e => e.NwcInvoicesTotalReasons)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Invoices_Total_Reasons");

                entity.Property(e => e.NwcInvoicesWastewaterConsumptionValue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("NWC_Invoices_Wastewater_Consumption_Value");

                entity.Property(e => e.NwcInvoicesYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Invoices_Year")
                    .IsFixedLength(true);

                entity.HasOne(d => d.NwcInvoicesRrealEstateTypesNavigation)
                    .WithMany(p => p.NwcInvoices)
                    .HasForeignKey(d => d.NwcInvoicesRrealEstateTypes)
                    .HasConstraintName("FK__NWC_Invoi__NWC_I__440B1D61");

                entity.HasOne(d => d.NwcInvoicesSubscriberNoNavigation)
                    .WithMany(p => p.NwcInvoices)
                    .HasForeignKey(d => d.NwcInvoicesSubscriberNo)
                    .HasConstraintName("FK__NWC_Invoi__NWC_I__4222D4EF");

                entity.HasOne(d => d.NwcInvoicesSubscriptionNoNavigation)
                    .WithMany(p => p.NwcInvoices)
                    .HasForeignKey(d => d.NwcInvoicesSubscriptionNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__NWC_Invoi__NWC_I__4316F928");
            });

            modelBuilder.Entity<NwcRrealEstateType>(entity =>
            {
                entity.HasKey(e => e.NwcRrealEstateTypesCode)
                    .HasName("PK__NWC_Rrea__B48E76EF137C89DA");

                entity.ToTable("NWC_Rreal_Estate_Types");

                entity.Property(e => e.NwcRrealEstateTypesCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Rreal_Estate_Types_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcRrealEstateTypesName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Rreal_Estate_Types_Name");

                entity.Property(e => e.NwcRrealEstateTypesReasons)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Rreal_Estate_Types_Reasons");
            });

            modelBuilder.Entity<NwcSubscriberFile>(entity =>
            {
                entity.ToTable("NWC_Subscriber_File");

                entity.Property(e => e.NwcSubscriberFileId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscriber_File_Id")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcSubscriberFileArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscriber_File_Area");

                entity.Property(e => e.NwcSubscriberFileCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscriber_File_City");

                entity.Property(e => e.NwcSubscriberFileMobile)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscriber_File_Mobile");

                entity.Property(e => e.NwcSubscriberFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscriber_File_Name");

                entity.Property(e => e.NwcSubscriberFileReasons)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscriber_File_Reasons");
            });

            modelBuilder.Entity<NwcSubscriptionFile>(entity =>
            {
                entity.HasKey(e => e.NwcSubscriptionFileNo)
                    .HasName("PK__NWC_Subs__FFCE2F6B8A70BD0E");

                entity.ToTable("NWC_Subscription_File");

                entity.Property(e => e.NwcSubscriptionFileNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscription_File_No")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcSubscriptionFileIsThereSanitation).HasColumnName("NWC_Subscription_File_Is_There_Sanitation");

                entity.Property(e => e.NwcSubscriptionFileLastReadingMeter)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("NWC_Subscription_File_Last_Reading_Meter");

                entity.Property(e => e.NwcSubscriptionFileReasons)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscription_File_Reasons");

                entity.Property(e => e.NwcSubscriptionFileRrealEstateTypesCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscription_File_Rreal_Estate_Types_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcSubscriptionFileSubscriberCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NWC_Subscription_File_Subscriber_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.NwcSubscriptionFileUnitNo)
                    .HasColumnType("numeric(2, 0)")
                    .HasColumnName("NWC_Subscription_File_Unit_No");

                entity.HasOne(d => d.NwcSubscriptionFileRrealEstateTypesCodeNavigation)
                    .WithMany(p => p.NwcSubscriptionFiles)
                    .HasForeignKey(d => d.NwcSubscriptionFileRrealEstateTypesCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__NWC_Subsc__NWC_S__3F466844");

                entity.HasOne(d => d.NwcSubscriptionFileSubscriberCodeNavigation)
                    .WithMany(p => p.NwcSubscriptionFiles)
                    .HasForeignKey(d => d.NwcSubscriptionFileSubscriberCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__NWC_Subsc__NWC_S__3E52440B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
