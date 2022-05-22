using System;
using System.Collections.Generic;

#nullable disable

namespace TaskTracker.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public int UserIdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string DepartmentName { get; set; }
        public string Status { get; set; }
    }
}
