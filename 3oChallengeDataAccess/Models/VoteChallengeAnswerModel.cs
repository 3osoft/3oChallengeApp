using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeDataAccess
{
    public class VoteChallengeAnswerModel
    {
        public int Id { get; set; }
        public UserModel User { get; set; }
        public string Value { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
