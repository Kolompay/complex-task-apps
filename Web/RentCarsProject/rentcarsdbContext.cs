using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RentCarsProject
{
    public partial class rentcarsdbContext : DbContext
    {
        public rentcarsdbContext()
        {
        }

        public rentcarsdbContext(DbContextOptions<rentcarsdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Bonussystem> Bonussystems { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Fine> Fines { get; set; }
        public virtual DbSet<Locationcar> Locationcars { get; set; }
        public virtual DbSet<Rate> Rates { get; set; }
        public virtual DbSet<Rentcar> Rentcars { get; set; }
        public virtual DbSet<Returncar> Returncars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=rentcarsdb;User Id=postgres;Password=pass;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEnd).HasColumnType("timestamp with time zone");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Bonussystem>(entity =>
            {
                entity.HasKey(e => e.Idbonussystem);

                entity.ToTable("bonussystem");

                entity.Property(e => e.Idbonussystem).HasColumnName("IDbonussystem");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Idcar);

                entity.ToTable("car");

                entity.HasIndex(e => e.LocationcarIdlocationcar, "IX_car_locationcarIDlocationcar");

                entity.Property(e => e.Idcar).HasColumnName("IDCar");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClassCar)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Idlocationcar).HasColumnName("IDlocationcar");

                entity.Property(e => e.LocationcarIdlocationcar).HasColumnName("locationcarIDlocationcar");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Vinnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VINnumber");

                entity.HasOne(d => d.LocationcarIdlocationcarNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.LocationcarIdlocationcar);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Idclient);

                entity.ToTable("client");

                entity.HasIndex(e => e.BonussystemIdbonussystem, "IX_client_bonussystemIDbonussystem");

                entity.Property(e => e.Idclient).HasColumnName("IDclient");

                entity.Property(e => e.BonussystemIdbonussystem).HasColumnName("bonussystemIDbonussystem");

                entity.Property(e => e.Familyname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idbonussystem).HasColumnName("IDbonussystem");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Numberofphone)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Patronymic)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.BonussystemIdbonussystemNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.BonussystemIdbonussystem);
            });

            modelBuilder.Entity<Fine>(entity =>
            {
                entity.HasKey(e => e.Idfine);

                entity.ToTable("fine");

                entity.HasIndex(e => e.ClientIdclient, "IX_fine_clientIDclient");

                entity.Property(e => e.Idfine).HasColumnName("IDfine");

                entity.Property(e => e.ClientIdclient).HasColumnName("clientIDclient");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(70);

                entity.Property(e => e.Idclient).HasColumnName("IDclient");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.ClientIdclientNavigation)
                    .WithMany(p => p.Fines)
                    .HasForeignKey(d => d.ClientIdclient);
            });

            modelBuilder.Entity<Locationcar>(entity =>
            {
                entity.HasKey(e => e.Idlocationcar);

                entity.ToTable("locationcar");

                entity.Property(e => e.Idlocationcar).HasColumnName("IDlocationcar");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Terrain)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.HasKey(e => e.Idrate);

                entity.ToTable("rate");

                entity.HasIndex(e => e.CarIdcar, "IX_rate_carIDCar");

                entity.Property(e => e.Idrate).HasColumnName("IDrate");

                entity.Property(e => e.CarIdcar).HasColumnName("carIDCar");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idcar).HasColumnName("IDcar");

                entity.HasOne(d => d.CarIdcarNavigation)
                    .WithMany(p => p.Rates)
                    .HasForeignKey(d => d.CarIdcar);
            });

            modelBuilder.Entity<Rentcar>(entity =>
            {
                entity.HasKey(e => e.Idrentcar);

                entity.ToTable("rentcar");

                entity.HasIndex(e => e.CarIdcar, "IX_rentcar_carIDCar");

                entity.HasIndex(e => e.ClientIdclient, "IX_rentcar_clientIDclient");

                entity.HasIndex(e => e.RateIdrate, "IX_rentcar_rateIDrate");

                entity.Property(e => e.Idrentcar).HasColumnName("IDrentcar");

                entity.Property(e => e.CarIdcar).HasColumnName("carIDCar");

                entity.Property(e => e.ClientIdclient).HasColumnName("clientIDclient");

                entity.Property(e => e.Idcar).HasColumnName("IDcar");

                entity.Property(e => e.Idclient).HasColumnName("IDclient");

                entity.Property(e => e.Idrate).HasColumnName("IDrate");

                entity.Property(e => e.RateIdrate).HasColumnName("rateIDrate");

                entity.HasOne(d => d.CarIdcarNavigation)
                    .WithMany(p => p.Rentcars)
                    .HasForeignKey(d => d.CarIdcar);

                entity.HasOne(d => d.ClientIdclientNavigation)
                    .WithMany(p => p.Rentcars)
                    .HasForeignKey(d => d.ClientIdclient);

                entity.HasOne(d => d.RateIdrateNavigation)
                    .WithMany(p => p.Rentcars)
                    .HasForeignKey(d => d.RateIdrate);
            });

            modelBuilder.Entity<Returncar>(entity =>
            {
                entity.HasKey(e => e.Idreturncar);

                entity.ToTable("returncar");

                entity.HasIndex(e => e.CarIdcar, "IX_returncar_carIDCar");

                entity.Property(e => e.Idreturncar).HasColumnName("IDreturncar");

                entity.Property(e => e.CarIdcar).HasColumnName("carIDCar");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Idcar).HasColumnName("IDcar");

                entity.HasOne(d => d.CarIdcarNavigation)
                    .WithMany(p => p.Returncars)
                    .HasForeignKey(d => d.CarIdcar);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
