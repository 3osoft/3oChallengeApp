using System;
using System.Collections.Generic;
using System.Text;

namespace _3oChallengeDomain
{
    public class ChallengeJsonRequest
    {
        public ChallengeType Type { get; set; }
        public ChallengeRequest Challenge { get; set; }
    }

    public class ChallengeRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTill { get; set; }
    }
}
