using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeApp.Models.Entities
{
    public class ChallengeUser
    {
        public int ChallengeId { get; set; }
        public virtual Challenge Challenge { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
    }
}
