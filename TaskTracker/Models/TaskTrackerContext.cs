using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TaskTracker.Models
{
    public partial class TaskTrackerContext : DbContext
    {
        public TaskTrackerContext()
        {
        }

        public TaskTrackerContext(DbContextOptions<TaskTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityRecord> ActivityRecords { get; set; }
        public virtual DbSet<ActivityTask> ActivityTasks { get; set; }
        public virtual DbSet<ActivityWeek> ActivityWeeks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserStatus> UserStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-TTLN1EM6;Database=TaskTracker;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityRecord>(entity =>
            {
                entity.Property(e => e.ActivityRecordId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorUserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ActivityWeek)
                    .WithMany(p => p.ActivityRecords)
                    .HasForeignKey(d => d.ActivityWeekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityWeeks");
            });

            modelBuilder.Entity<ActivityTask>(entity =>
            {
                entity.Property(e => e.ActivityTaskId).ValueGeneratedNever();

                entity.Property(e => e.Activity).IsUnicode(false);

                entity.Property(e => e.ActivityDate).HasColumnType("datetime");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Completed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.Project).IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.ActivityRecord)
                    .WithMany(p => p.ActivityTasks)
                    .HasForeignKey(d => d.ActivityRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityRecords");
            });

            modelBuilder.Entity<ActivityWeek>(entity =>
            {
                entity.Property(e => e.ActivityWeekId).ValueGeneratedNever();

                entity.Property(e => e.WeekEndDate).HasColumnType("datetime");

                entity.Property(e => e.WeekStartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserStatus>(entity =>
            {
                entity.ToTable("UserStatus");

                entity.Property(e => e.UserStatusId).ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
