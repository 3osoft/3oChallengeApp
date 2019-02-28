using Microsoft.EntityFrameworkCore;

namespace _3oChallengeDataAccess
{
    public class ApiDbContext : DbContext
    {

        public DbSet<ChallengeModel> Challenges { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<InputChallengeModel> InputChallenges { get; set; }
        public DbSet<InputChallengeAnswerModel> InputChallengeAnswers { get; set; }
        public DbSet<VoteChallengeModel> VoteChallenges { get; set; }
        public DbSet<VoteChallengeItemModel> VoteChallengeItems { get; set; }
        public DbSet<VoteChallengeAnswerModel> VoteChallengeAnswers { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChallengeUserModel>().HasKey(chu => new { chu.ChallengeId, chu.UserId });

            modelBuilder.Entity<ChallengeUserModel>()
                .HasOne(chu => chu.Challenge)
                .WithMany(challenge => challenge.ChallengeUsers)
                .HasForeignKey(chu => chu.ChallengeId);

            modelBuilder.Entity<ChallengeUserModel>()
                .HasOne(chu => chu.User)
                .WithMany(user => user.ChallengeUsers)
                .HasForeignKey(chu => chu.UserId);
        }

    }
}