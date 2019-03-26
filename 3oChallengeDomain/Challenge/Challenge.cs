using System;
using System.Collections.Generic;
using System.Text;

namespace _3oChallengeDomain
{
    public class Challenge
    {
        public int? Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatorId { get; set; }
        public bool IsEnabled { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTill { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

        public Challenge(int id)
        {
            Id = id;
        }

        public Challenge(string title, string description, DateTimeOffset validFrom, DateTimeOffset validTill, string creatorId)
        {
            this.Title = title;
            this.Description = description;
            this.ValidFrom = validFrom;
            this.ValidTill = validTill;
            this.CreatorId = creatorId;
            this.IsEnabled = true;
            this.CreatedAt = DateTime.UtcNow;
            this.UpdatedAt = DateTime.UtcNow;
        }
    }
}
