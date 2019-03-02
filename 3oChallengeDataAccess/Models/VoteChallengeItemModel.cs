using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3oChallengeDataAccess
{
    public class VoteChallengeItemModel
    {
        public VoteChallengeItemModel()
        {
            this.Answers = new HashSet<VoteChallengeAnswerModel>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public string Value { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public virtual ICollection<VoteChallengeAnswerModel> Answers { get; set; }
        public int VoteChallengeId { get; set; }
        public VoteChallengeModel VoteChallenge { get; set; }
    }
}
