using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeApp.Models.Entities
{
    public class User
    {
        public User()
        {
            Challenges = new HashSet<Challenge>();
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
        public List<ChallengeUser> ChallengeUsers { get; set; }
        public ICollection<Challenge> Challenges { get; set; }

        
    }
}
