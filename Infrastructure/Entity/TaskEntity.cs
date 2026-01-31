using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace DataAccess.Entity
{
    public class TaskEntity
    {
        public int Id { get; set; }

        public int? TeamId { get; set; }
        public string Title { get; set; } = null!;
        public TaskType Type { get; set; }

        public string Criteria { get; set; } = null!;
        public string? Reward { get; set; }

        public int CreatedBy { get; set; }
        public DateTime DueDate { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
