using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BookMyMovie.Models
{
    public partial class movieDBContext : DbContext
    {
        public movieDBContext()
        {
        }

        public movieDBContext(DbContextOptions<movieDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AddMovie> AddMovies { get; set; }
        public virtual DbSet<Smovie> Smovies { get; set; }
        public virtual DbSet<TblAdmin> TblAdmins { get; set; }
        public virtual DbSet<TblConfirmation> TblConfirmations { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblPayment> TblPayments { get; set; }
        public virtual DbSet<TblReceipt> TblReceipts { get; set; }
        public virtual DbSet<Tblregister> Tblregisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AddMovie>(entity =>
            {
                entity.ToTable("AddMovie");

                entity.Property(e => e.MovieImage)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.MovieName).HasMaxLength(100);
            });

            modelBuilder.Entity<Smovie>(entity =>
            {
                entity.ToTable("smovie");

                entity.Property(e => e.SelectAge)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Select-Age");

                entity.Property(e => e.SelectDate)
                    .HasColumnType("date")
                    .HasColumnName("Select-Date");

                entity.Property(e => e.SelectGender)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Select-Gender");

                entity.Property(e => e.SelectMovie)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Select-Movie");

                entity.Property(e => e.SelectSeats).HasColumnName("Select-Seats");

                entity.Property(e => e.SelectTheater)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Select-Theater");

                entity.Property(e => e.SelectTime)
                    .HasColumnType("time(0)")
                    .HasColumnName("Select-Time");
            });

            modelBuilder.Entity<TblAdmin>(entity =>
            {
                entity.ToTable("TblAdmin");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(100);
            });

            modelBuilder.Entity<TblConfirmation>(entity =>
            {
                entity.ToTable("TblConfirmation");

                entity.Property(e => e.MovieName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Movie Name");

                entity.Property(e => e.NoOfTickets).HasColumnName("No.of Tickets");

                entity.Property(e => e.TheaterName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Theater Name");
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPayment>(entity =>
            {
                entity.ToTable("TblPayment");

                entity.Property(e => e.Upiid).HasColumnName("UPIID");
            });

            modelBuilder.Entity<TblReceipt>(entity =>
            {
                entity.ToTable("TblReceipt");

                entity.Property(e => e.Fare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Movie)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfTickets).HasColumnName("No.of Tickets");

                entity.Property(e => e.Show).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Theatre).HasMaxLength(100);
            });

            modelBuilder.Entity<Tblregister>(entity =>
            {
                entity.ToTable("Tblregister");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
