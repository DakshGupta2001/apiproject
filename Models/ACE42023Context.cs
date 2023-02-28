using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FirstApi.Models
{
    public partial class ACE42023Context : DbContext
    {
        public ACE42023Context()
        {
        }

        public ACE42023Context(DbContextOptions<ACE42023Context> options)
            : base(options)
        {
        }

        public virtual DbSet<DakshUser> DakshUsers { get; set; }
        public virtual DbSet<Empharshit> Empharshits { get; set; }
        public virtual DbSet<HarshitAuth> HarshitAuths { get; set; }
        public virtual DbSet<SuneetDept> SuneetDepts { get; set; }
        public virtual DbSet<SuneetEmployee> SuneetEmployees { get; set; }
        public virtual DbSet<SuneetUser> SuneetUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DEVSQL.corp.local;Database=ACE 4- 2023;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DakshUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__DakshUse__1788CC4C5F10387A");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userpassword)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empharshit>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__empharsh__D9509F6D853D881C");

                entity.ToTable("empharshit");

                entity.Property(e => e.Eid)
                    .ValueGeneratedNever()
                    .HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("doj");

                entity.Property(e => e.Ename)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<HarshitAuth>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("PK__HarshitA__C9F28457BE78B4C4");

                entity.ToTable("HarshitAuth");

                entity.Property(e => e.UserName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuneetDept>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Suneet_D__0148818EA754B5DB");

                entity.ToTable("Suneet_Dept");

                entity.Property(e => e.DeptId)
                    .ValueGeneratedNever()
                    .HasColumnName("DeptID");

                entity.Property(e => e.Dname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_Employees");
            });

            modelBuilder.Entity<SuneetEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Suneet_E__7AD04FF1F58F10EF");

                entity.ToTable("Suneet_Employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_birth");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.SuneetEmployees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK__Suneet_Em__DeptI__18B6AB08");
            });

            modelBuilder.Entity<SuneetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Suneet_U__1788CCACBFF2E4B3");

                entity.ToTable("Suneet_Users");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userpassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
