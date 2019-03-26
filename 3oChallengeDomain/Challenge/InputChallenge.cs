using System;
using System.Collections.Generic;
using System.Text;

namespace _3oChallengeDomain
{
    public class InputChallenge : Challenge
    {
        public InputChallenge(int id) : base(id)
        {

        }

        public InputChallenge(string title, string description, DateTimeOffset validFrom, DateTimeOffset validTill, string creatorId) : 
            base(title, description, validFrom, validTill, creatorId)
        {

        }
    }
}
