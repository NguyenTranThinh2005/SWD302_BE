using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Profile
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string? TopErrors { get; set; }
        public string? GrammarTree { get; set; }
        public string? Badges { get; set; }
        public string? WeeklyGraph { get; set; }

        public User User { get; set; } = null!;
    }
}
