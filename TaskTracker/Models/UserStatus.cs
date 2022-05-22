using System;
using System.Collections.Generic;

#nullable disable

namespace TaskTracker.Models
{
    public partial class UserStatus
    {
        public int UserStatusId { get; set; }
        public int UserIdNumber { get; set; }
        public string Status { get; set; }
    }
}
