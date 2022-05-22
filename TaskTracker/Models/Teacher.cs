using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Template.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        [Key]
        public int TeacherId { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeInLocalTime { get; set; }
        [Column("DateTimeInUTC", TypeName = "datetime")]
        public DateTime? DateTimeInUtc { get; set; }

        [InverseProperty(nameof(TeacherSubject.Teacher))]
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
