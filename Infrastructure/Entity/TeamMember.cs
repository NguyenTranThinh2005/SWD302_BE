using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;

namespace DataAccess.Entity
{
    public class TeamMember
    {
        public int Id { get; set; }

        public int TeamId { get; set; }
        public int UserId { get; set; }

        public TeamRole Role { get; set; } = TeamRole.Member;
        public DateTime JoinDate { get; set; }

        public Team Team { get; set; } = null!;
        public User User { get; set; } = null!;
    }

}
