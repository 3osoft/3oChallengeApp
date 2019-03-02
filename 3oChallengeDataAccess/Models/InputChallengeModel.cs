using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3oChallengeDataAccess
{
    public class InputChallengeModel
    {
        public InputChallengeModel()
        {
            this.Answers = new HashSet<InputChallengeAnswerModel>();
        }

        public int Id { get; set; }
        public int ChallengeId { get; set; }
        public ChallengeModel Challenge { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public virtual ICollection<InputChallengeAnswerModel> Answers { get; set; }
    }
}
