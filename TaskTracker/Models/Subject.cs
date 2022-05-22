using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Template.Models
{
    public partial class Subject
    {
        public Subject()
        {
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        [Key]
        public int SubjectId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty(nameof(TeacherSubject.Subject))]
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
