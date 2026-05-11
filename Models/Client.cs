using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Platform_for_freelancing.Models
{
    public class Client : User
    {
        public Client()
        {
            Orders = new List<Order>();
        }

        [Display(Name = "Назва компанії")]
        public string? CompanyName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}