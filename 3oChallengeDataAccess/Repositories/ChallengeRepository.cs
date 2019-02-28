using _3oChallengeDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3oChallengeDataAccess
{
    public class ChallengeRepository : Repository<ChallengeModel>, IChallengeRepository
    {
        public ChallengeRepository(ApiDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Challenge> GetAllChallenges()
        {
            return this.GetAll().Select(c => new Challenge(c.Id)).ToList();
        }
    }
}
