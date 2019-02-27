using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeApp.Models.Entities
{
    public class VoteChallengeAnswer
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Value { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
