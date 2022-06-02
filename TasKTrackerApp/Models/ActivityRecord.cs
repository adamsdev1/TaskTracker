using System;
using System.Collections.Generic;

#nullable disable

namespace TasKTrackerApp.Models
{
    public partial class ActivityRecord
    {
        public ActivityRecord()
        {
            ActivityTasks = new HashSet<ActivityTask>();
        }

        public long ActivityRecordId { get; set; }
        public long ActivityWeekId { get; set; }
        public int UserIdNumber { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public string DepartmentName { get; set; }
        public string ManagerName { get; set; }
        public int? SupervisorIdNumber { get; set; }
        public string SupervisorUserName { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ActivityWeek ActivityWeek { get; set; }
        public virtual ICollection<ActivityTask> ActivityTasks { get; set; }
    }
}
