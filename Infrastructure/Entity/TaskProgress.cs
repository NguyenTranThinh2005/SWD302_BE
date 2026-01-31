using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class TaskProgress
    {
        public int Id { get; set; }

        public int TaskId { get; set; }
        public int UserId { get; set; }

        public int CurrentProgress { get; set; }
        public int TargetValue { get; set; }

        public TaskStatus Status { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}

