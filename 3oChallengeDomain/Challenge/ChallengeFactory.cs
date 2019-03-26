using System;
using System.Collections.Generic;
using System.Text;

namespace _3oChallengeDomain
{
    public class ChallengeFactory
    {
        public static Challenge Construct(string creatorId, ChallengeJsonRequest challengeData)
        {
            Challenge challenge = null;
            switch (challengeData.Type)
            {
                case ChallengeType.Input:
                    var title = challengeData.Challenge.Title;
                    var description = challengeData.Challenge.Description;
                    var validFrom = challengeData.Challenge.ValidFrom;
                    var validTill = challengeData.Challenge.ValidTill;
                    challenge = new InputChallenge(title, description, validFrom, validTill, creatorId);
                    break;
                case ChallengeType.Vote:
                    break;

            }
            return challenge;
        }
    }
}
