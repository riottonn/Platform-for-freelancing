using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Platform_for_freelancing.Models
{
    public class Order
    {
        public Order()
        {
            Bids = new List<Bid>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва замовлення")]
        public string Title { get; set; }

        [Display(Name = "Опис")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Бюджет")]
        public decimal Budget { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }
    }
}