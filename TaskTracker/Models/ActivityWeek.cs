using System;
using System.Collections.Generic;

#nullable disable

namespace TaskTracker.Models
{
    public partial class ActivityWeek
    {
        public ActivityWeek()
        {
            ActivityRecords = new HashSet<ActivityRecord>();
        }

        public long ActivityWeekId { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public DateTime? WeekEndDate { get; set; }

        public virtual ICollection<ActivityRecord> ActivityRecords { get; set; }
    }
}
