using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _3oChallengeDataAccess
{
    [Table("ChallengeUser")]
    public class ChallengeUserModel
    {
        [Required]
        public int ChallengeId { get; set; }
        public virtual ChallengeModel Challenge { get; set; }
        [Required]
        public string UserId { get; set; }
        
    }
}
