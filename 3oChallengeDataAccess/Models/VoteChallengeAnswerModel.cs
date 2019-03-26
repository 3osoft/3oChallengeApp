using System;
using System.ComponentModel.DataAnnotations;

namespace _3oChallengeDataAccess
{
    public class VoteChallengeAnswerModel
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string Value { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public int VoteChallengeItemId { get; set; }
        public VoteChallengeItemModel VoteChallengeItem { get; set; }
    }
}
