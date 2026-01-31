using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class GameSession
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int GameId { get; set; }

        public int SessionScore { get; set; }
        public int StarsEarned { get; set; }
        public int CoinsEarned { get; set; }

        public string? ErrorLog { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? Step { get; set; }

        public User User { get; set; } = null!;
        public Game Game { get; set; } = null!;
    }

}
