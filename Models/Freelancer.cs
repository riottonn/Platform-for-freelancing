using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Platform_for_freelancing.Models
{
    public class Freelancer : User
    {
        public Freelancer()
        {
            Bids = new List<Bid>();
        }

        [Display(Name = "Навички")]
        public string? Skills { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }
    }
}