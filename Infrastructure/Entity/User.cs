using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccess.Entity
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string PasswordHash { get; set; } = null!;
        public string? AvatarUrl { get; set; }

        public int Grade { get; set; }
        public Region Region { get; set; }
        public UserRole Role { get; set; } = UserRole.User;

        public bool IsActive { get; set; } = true;
        public int Progress { get; set; }
        public int Streaks { get; set; }
        public decimal Accuracy { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public Profile? Profile { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; } = new List<TeamMember>();
    }

}
