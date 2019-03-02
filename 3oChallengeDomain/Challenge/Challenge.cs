using System;
using System.Collections.Generic;
using System.Text;

namespace _3oChallengeDomain
{
    public class Challenge
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Challenge(int id)
        {
            Id = id;
        }
    }
}
