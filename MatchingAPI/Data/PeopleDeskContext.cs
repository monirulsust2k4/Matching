using System;
using System.Collections.Generic;
using MatchingAPI.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace MatchingAPI.Data;

public partial class PeopleDeskContext : DbContext
{
    public PeopleDeskContext()
    {
    }

    public PeopleDeskContext(DbContextOptions<PeopleDeskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NotificationCategoriesType> NotificationCategoriesTypes { get; set; }

    public virtual DbSet<NotificationCategory> NotificationCategories { get; set; }

    public virtual DbSet<NotificationDetail> NotificationDetails { get; set; }

    public virtual DbSet<NotificationMaster> NotificationMasters { get; set; }

    public virtual DbSet<NotifySendFailedLog> NotifySendFailedLogs { get; set; }

    public virtual DbSet<Url> Urls { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=10.209.99.244;Initial Catalog=PeopleDeskARL;User ID=isukisespts3vapp8dt;Password=wsa0str1vpo@8d5ws;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NotificationCategoriesType>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("NotificationCategoriesType", "signalR");

            entity.Property(e => e.IntId).HasColumnName("intId");
            entity.Property(e => e.DteCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedAt");
            entity.Property(e => e.DteUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteUpdatedAt");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntUpdatedBy).HasColumnName("intUpdatedBy");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.StrTypeName)
                .HasMaxLength(500)
                .HasColumnName("strTypeName");
        });

        modelBuilder.Entity<NotificationCategory>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("NotificationCategories", "signalR");

            entity.Property(e => e.IntId).HasColumnName("intId");
            entity.Property(e => e.DteCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedAt");
            entity.Property(e => e.DteUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteUpdatedAt");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntUpdatedBy).HasColumnName("intUpdatedBy");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.StrCategoriesName)
                .HasMaxLength(500)
                .HasColumnName("strCategoriesName");
            entity.Property(e => e.StrGenericMessageText).HasColumnName("strGenericMessageText");
            entity.Property(e => e.StrImageUrl).HasColumnName("strImageUrl");
        });

        modelBuilder.Entity<NotificationDetail>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("NotificationDetails", "signalR");

            entity.Property(e => e.IntId).HasColumnName("intId");
            entity.Property(e => e.DteCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedAt");
            entity.Property(e => e.IntMasterId).HasColumnName("intMasterId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.StrCreatedBy)
                .HasMaxLength(150)
                .HasColumnName("strCreatedBy");
            entity.Property(e => e.StrReceiver)
                .HasMaxLength(150)
                .HasColumnName("strReceiver");
        });

        modelBuilder.Entity<NotificationMaster>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("NotificationMaster", "signalR");

            entity.Property(e => e.IntId).HasColumnName("intId");
            entity.Property(e => e.DteCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedAt");
            entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");
            entity.Property(e => e.IntFeatureTableAutoId).HasColumnName("intFeatureTableAutoId");
            entity.Property(e => e.IntModuleId).HasColumnName("intModuleId");
            entity.Property(e => e.IntOrgId).HasColumnName("intOrgId");
            entity.Property(e => e.IntUserId).HasColumnName("intUserId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsCommon).HasColumnName("isCommon");
            entity.Property(e => e.IsSeen).HasColumnName("isSeen");
            entity.Property(e => e.StrCreatedBy)
                .HasMaxLength(150)
                .HasColumnName("strCreatedBy");
            entity.Property(e => e.StrFeature)
                .HasMaxLength(500)
                .HasColumnName("strFeature");
            entity.Property(e => e.StrLoginId).HasColumnName("strLoginId");
            entity.Property(e => e.StrModule)
                .HasMaxLength(500)
                .HasColumnName("strModule");
            entity.Property(e => e.StrNotifyDetails).HasColumnName("strNotifyDetails");
            entity.Property(e => e.StrNotifyTitle)
                .HasMaxLength(500)
                .HasColumnName("strNotifyTitle");
            entity.Property(e => e.StrReceiver)
                .HasMaxLength(150)
                .HasColumnName("strReceiver");
        });

        modelBuilder.Entity<NotifySendFailedLog>(entity =>
        {
            entity.HasKey(e => e.IntId);

            entity.ToTable("NotifySendFailedLog", "signalR");

            entity.Property(e => e.IntId).HasColumnName("intId");
            entity.Property(e => e.DteCreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedAt");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntEmployeeId).HasColumnName("intEmployeeId");
            entity.Property(e => e.IntFeatureTableAutoId).HasColumnName("intFeatureTableAutoId");
            entity.Property(e => e.StrFeature)
                .HasMaxLength(50)
                .HasColumnName("strFeature");
        });

        modelBuilder.Entity<Url>(entity =>
        {
            entity.HasKey(e => e.IntUrlId).HasName("PK__URLs__60EAF4A9F4290110");

            entity.ToTable("URLs", "core");

            entity.Property(e => e.IntUrlId)
                .ValueGeneratedNever()
                .HasColumnName("intUrlId");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.StrDomainName)
                .HasMaxLength(250)
                .HasColumnName("strDomainName");
            entity.Property(e => e.StrIpaddress)
                .HasMaxLength(250)
                .HasColumnName("strIPAddress");
            entity.Property(e => e.StrUrl).HasColumnName("strURL");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IntUserId);

            entity.ToTable("Users", "auth");

            entity.Property(e => e.IntUserId).HasColumnName("intUserId");
            entity.Property(e => e.DteCreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedAt");
            entity.Property(e => e.DteLastLogin)
                .HasColumnType("datetime")
                .HasColumnName("dteLastLogin");
            entity.Property(e => e.DteUpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("dteUpdatedAt");
            entity.Property(e => e.IntAccountId).HasColumnName("intAccountId");
            entity.Property(e => e.IntCreatedBy).HasColumnName("intCreatedBy");
            entity.Property(e => e.IntRefferenceId).HasColumnName("intRefferenceId");
            entity.Property(e => e.IntUpdatedBy).HasColumnName("intUpdatedBy");
            entity.Property(e => e.IntUrlId).HasColumnName("intUrlId");
            entity.Property(e => e.IntUserTypeId).HasColumnName("intUserTypeId");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsOfficeAdmin)
                .HasDefaultValue(false)
                .HasColumnName("isOfficeAdmin");
            entity.Property(e => e.IsOwner).HasColumnName("isOwner");
            entity.Property(e => e.IsSuperuser)
                .HasDefaultValue(false)
                .HasColumnName("isSuperuser");
            entity.Property(e => e.StrDisplayName)
                .HasMaxLength(250)
                .HasColumnName("strDisplayName");
            entity.Property(e => e.StrLoginFacbookId)
                .HasMaxLength(500)
                .HasColumnName("strLoginFacbookId");
            entity.Property(e => e.StrLoginGmailId)
                .HasMaxLength(500)
                .HasColumnName("strLoginGmailId");
            entity.Property(e => e.StrLoginId)
                .HasMaxLength(250)
                .HasColumnName("strLoginId");
            entity.Property(e => e.StrOldPassword)
                .HasMaxLength(250)
                .HasColumnName("strOldPassword");
            entity.Property(e => e.StrPassword)
                .HasMaxLength(250)
                .HasColumnName("strPassword");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
