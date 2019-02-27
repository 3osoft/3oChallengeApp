using _3oChallengeApp.Models;
using _3oChallengeApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _3oChallenge
{
    public class ApiDbContext : DbContext
    {

        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InputChallenge> InputChallenges { get; set; }
        public DbSet<InputChallengeAnswer> InputChallengeAnswers { get; set; }
        public DbSet<VoteChallenge> VoteChallenges { get; set; }
        public DbSet<VoteChallengeItem> VoteChallengeItems { get; set; }
        public DbSet<VoteChallengeAnswer> VoteChallengeAnswers { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChallengeUser>().HasKey(chu => new { chu.ChallengeId, chu.UserId });

            modelBuilder.Entity<ChallengeUser>()
                .HasOne(chu => chu.Challenge)
                .WithMany(challenge => challenge.ChallengeUsers)
                .HasForeignKey(chu => chu.ChallengeId);

            modelBuilder.Entity<ChallengeUser>()
                .HasOne(chu => chu.User)
                .WithMany(user => user.ChallengeUsers)
                .HasForeignKey(chu => chu.UserId);
        }

    }
}