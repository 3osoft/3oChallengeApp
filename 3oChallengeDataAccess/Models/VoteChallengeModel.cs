using System;
using System.Collections.Generic;

namespace _3oChallengeDataAccess
{
    public class VoteChallengeModel
    {
        public VoteChallengeModel()
        {
            this.Items = new HashSet<VoteChallengeItemModel>();
        }

        public int Id { get; set; }
        public ChallengeModel Challenge { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public virtual ICollection<VoteChallengeItemModel> Items { get; set; }
    }
}
