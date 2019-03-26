using Microsoft.EntityFrameworkCore;

namespace _3oChallengeDataAccess
{
    public class ApiDbContext : DbContext
    {

        public DbSet<ChallengeModel> Challenge { get; set; }
        public DbSet<InputChallengeModel> InputChallenge { get; set; }
        public DbSet<InputChallengeAnswerModel> InputChallengeAnswer { get; set; }
        public DbSet<VoteChallengeModel> VoteChallenge { get; set; }
        public DbSet<VoteChallengeItemModel> VoteChallengeItem { get; set; }
        public DbSet<VoteChallengeAnswerModel> VoteChallengeAnswer { get; set; }

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
        }

    }
}