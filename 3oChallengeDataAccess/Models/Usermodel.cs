using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeDataAccess
{
    public class UserModel
    {
        public UserModel()
        {
            Challenges = new HashSet<ChallengeModel>();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public ICollection<ChallengeUserModel> ChallengeUsers { get; set; }
        public ICollection<ChallengeModel> Challenges { get; set; }

        
    }
}
