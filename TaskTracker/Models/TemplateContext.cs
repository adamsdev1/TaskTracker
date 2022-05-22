using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Template.Models
{
    public partial class TemplateContext : DbContext
    {
        public TemplateContext()
        {
        }

        public TemplateContext(DbContextOptions<TemplateContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-TTLN1EM6;Database=DevTemplateDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.TeacherId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            modelBuilder.Entity<TeacherSubject>(entity =>
            {
                entity.HasKey(e => e.TeacherSubjectsId)
                    .HasName("PK__TeacherS__AB942DDDA4D03848");

                entity.Property(e => e.TeacherSubjectsId).ValueGeneratedNever();

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__TeacherSu__Subje__37A5467C");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherSubjects)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__TeacherSu__Teach__36B12243");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
