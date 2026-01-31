using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Team
    {
        public int Id { get; set; }

        public int OwnerId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? InviteCode { get; set; }

        public decimal AvgAccuracy { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<TeamMember> Members { get; set; } = new List<TeamMember>();
    }

}
