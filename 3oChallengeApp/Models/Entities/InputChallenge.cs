using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeApp.Models.Entities
{
    public class InputChallenge
    {
        public InputChallenge()
        {
            this.Answers = new HashSet<InputChallengeAnswer>();
        }

        public int Id { get; set; }
        public Challenge Challenge { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public virtual ICollection<InputChallengeAnswer> Answers { get; set; }
    }
}
