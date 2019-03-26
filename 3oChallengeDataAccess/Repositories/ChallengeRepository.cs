using _3oChallengeDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _3oChallengeDataAccess
{
    public class ChallengeRepository : Repository<InputChallengeModel>, IChallengeRepository
    {
        public ChallengeRepository(ApiDbContext dbContext) : base(dbContext)
        {
        }

        public Challenge Create(Challenge challenge)
        {
            ChallengeModel model = new ChallengeModel();
            model.Title = challenge.Title;
            model.Description = challenge.Description;
            model.IsEnabled = challenge.IsEnabled;
            model.CreatorId = challenge.CreatorId;
            model.ValidFrom = challenge.ValidFrom;
            model.ValidTill = challenge.ValidTill;
            model.CreatedAt = challenge.CreatedAt;
            model.UpdatedAt = challenge.UpdatedAt;

            InputChallengeModel inputChallenge = new InputChallengeModel();
            inputChallenge.Challenge = model;
            this.Insert(inputChallenge);

            this.Save();
            return null;
        }

        public IEnumerable<Challenge> GetAllChallenges()
        {
            yield return new Challenge(1);
        }
    }
}
