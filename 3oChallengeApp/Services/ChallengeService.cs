using _3oChallengeDomain;
using Microsoft.AspNetCore.Http;
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

        public Challenge Create(string creatorId, ChallengeJsonRequest challengeData)
        {
            Challenge challenge = ChallengeFactory.Construct(creatorId, challengeData);
            return _repository.Create(challenge);
        }
    }
}
