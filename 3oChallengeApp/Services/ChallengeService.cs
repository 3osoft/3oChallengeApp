using _3oChallengeDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeApp.Services
{
    public class ChallengeService
    {
        private readonly IChallengeRepository _repository;
        public ChallengeService(IChallengeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Challenge> GetAllChallenges()
        {
            return _repository.GetAllChallenges();
        }
    }
}
