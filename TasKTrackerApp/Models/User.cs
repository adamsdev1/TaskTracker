using System;
using System.Collections.Generic;

#nullable disable

namespace TasKTrackerApp.Models
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
        public string Email { get; set; }
        public string Gender { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public Guid UserAccountId { get; set; }
    }
}
