using Microsoft.EntityFrameworkCore;
using DataAccess.Entity;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // ===== Core content & game =====
        public DbSet<Content> Contents { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameSession> GameSessions { get; set; }

        // ===== User & profile =====
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }

        // ===== Task system =====
        public DbSet<TaskEntity> Tasks { get; set; }
        public DbSet<TaskProgress> TaskProgresses { get; set; }
        public DbSet<TaskCompletion> TaskCompletions { get; set; }

        // ===== Team system =====
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User - Profile (1 - 1)
            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<Profile>(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - GameSession (1 - n)
            modelBuilder.Entity<GameSession>()
                .HasOne(gs => gs.User)
                .WithMany()
                .HasForeignKey(gs => gs.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Game - GameSession (1 - n)
            modelBuilder.Entity<GameSession>()
                .HasOne(gs => gs.Game)
                .WithMany()
                .HasForeignKey(gs => gs.GameId)
                .OnDelete(DeleteBehavior.Cascade);

            // Team - TeamMember (1 - n)
            modelBuilder.Entity<TeamMember>()
                .HasOne(tm => tm.Team)
                .WithMany(t => t.Members)
                .HasForeignKey(tm => tm.TeamId)
                .OnDelete(DeleteBehavior.Cascade);

            // User - TeamMember (1 - n)
            modelBuilder.Entity<TeamMember>()
                .HasOne(tm => tm.User)
                .WithMany(u => u.TeamMembers)
                .HasForeignKey(tm => tm.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
