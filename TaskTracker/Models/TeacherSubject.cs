using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Template.Models
{
    public partial class TeacherSubject
    {
        [Key]
        public int TeacherSubjectsId { get; set; }
        public int? TeacherId { get; set; }
        public int? SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        [InverseProperty("TeacherSubjects")]
        public virtual Subject Subject { get; set; }
        [ForeignKey(nameof(TeacherId))]
        [InverseProperty("TeacherSubjects")]
        public virtual Teacher Teacher { get; set; }
    }
}
