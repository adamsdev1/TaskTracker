using System;
using System.Collections.Generic;

#nullable disable

namespace TaskTracker.Models
{
    public partial class ActivityTask
    {
        public long ActivityTaskId { get; set; }
        public long ActivityRecordId { get; set; }
        public DateTime? ActivityDate { get; set; }
        public int? ActivityHours { get; set; }
        public int? ActivityMinutes { get; set; }
        public string Activity { get; set; }
        public string Category { get; set; }
        public string Project { get; set; }
        public string Completed { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ActivityRecord ActivityRecord { get; set; }
    }
}
