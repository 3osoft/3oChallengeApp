using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _3oChallengeApp.Models.Entities
{
    public class Challenge
    {
        public Challenge()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTill { get; set; }
        public string WinnerCondition { get; set; }
        public bool IsEnabled { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public List<ChallengeUser> ChallengeUsers { get; set; }
        [NotMapped]
        public ICollection<User> Users { get; set; }
    }
}
