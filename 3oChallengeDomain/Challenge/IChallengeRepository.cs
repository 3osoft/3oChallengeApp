using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeDomain
{
    public interface IChallengeRepository
    {
        IEnumerable<Challenge> GetAllChallenges();

        Challenge Create(Challenge challenge);
    }
}
