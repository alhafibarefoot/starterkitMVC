using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarterKitAspNetCoreWebApp.CustomConnventions;
using StarterKitAspNetCoreWebApp.Models;

namespace StarterKitAspNetCoreWebApp.Presistance
{
    public class StarterKitProjectDBContext : DbContext
    {
        public StarterKitProjectDBContext(DbContextOptions<StarterKitProjectDBContext> options)
            : base(options) { }

        //// public virtual DbSet<BaseEntity> BaseEntity { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<SEC_RoleDelegation> SEC_RoleDelegation { get; set; }
        public virtual DbSet<SEC_RolePermission> SEC_RolePermission { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<LT_Country> LT_Country { get; set; }
        public virtual DbSet<LT_Governorate> LT_Governorate { get; set; }
        public virtual DbSet<LT_Region> LT_Region { get; set; }
        public virtual DbSet<LT_Area> LT_Area { get; set; }
        public virtual DbSet<LT_Road> LT_Road { get; set; }
        public virtual DbSet<LT_DivisionType> LT_DivisionType { get; set; }
        public virtual DbSet<STR_Company> STR_Company { get; set; }
        public virtual DbSet<SMT_System> SMT_System { get; set; }
        public virtual DbSet<SMT_Module> SMT_Module { get; set; }
        public virtual DbSet<SMT_Action> SMT_Action { get; set; }
        public virtual DbSet<LT_LookupTableReferance> LT_LookupTableReferance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType
                        .GetProperties()
                        .Where(p => p.PropertyType == typeof(decimal));
                    var dateTimeProperties = entityType.ClrType
                        .GetProperties()
                        .Where(p => p.PropertyType == typeof(DateTimeOffset));

                    foreach (var property in properties)
                    {
                        modelBuilder
                            .Entity(entityType.Name)
                            .Property(property.Name)
                            .HasConversion<double>();
                    }

                    foreach (var property in dateTimeProperties)
                    {
                        modelBuilder
                            .Entity(entityType.Name)
                            .Property(property.Name)
                            .HasConversion(new DateTimeOffsetToBinaryConverter());
                    }
                }
            }
            // Add your customizations after calling base.OnModelCreating(builder);
            CustomDataTypeAttributeConvention.Apply(modelBuilder);
            DecimalPrecisionAttributeConvention.Apply(modelBuilder);
            SqlDefaultValueAttributeConvention.Apply(modelBuilder);

            // Use Annotation [DecimalPrecision(18, 9)] [SqlDefaultValue("getutcdate()")] [DataType("decimal(18,9)")]

            // --------------------------------------------------------------------------
            //     modelBuilder.Entity<BaseEntity>(entity =>
            // {
            //     entity.HasNoKey();


            // });



            /// --------------------------------------------------------------------------


            modelBuilder
                .Entity<AspNetUserRole>()
                .HasKey(table => new { table.AspNetUserUserId, table.AspNetRoleRoleId });
            modelBuilder
                .Entity<AspNetUserLogin>()
                .HasKey(
                    table => new { table.LoginProvider, table.ProviderKey, table.AspNetUserUserId }
                );

            //HasAlternateKey method enables you to create an alternate key by placing a unique constraint (and therefore a unique index) on a property or properties other than those that form the primary key
            //We have to Spicify the statment other wise it will tretmente with ID as Normal Column , such as update and we have to exclude that

            modelBuilder.Entity<LT_Country>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<LT_Governorate>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<LT_Region>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<LT_Area>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<LT_Road>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<LT_DivisionType>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<AspNetUser>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<AspNetRole>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<AspNetUserClaim>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<SEC_RoleDelegation>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<SEC_RolePermission>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<SMT_Action>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<SMT_System>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<STR_Company>().HasAlternateKey(k => k.Id);
            modelBuilder.Entity<LT_LookupTableReferance>().HasAlternateKey(k => k.Id);

            //----------------------------------------------------------------------
        }
    }
}
