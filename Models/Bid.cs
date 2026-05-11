using System.ComponentModel.DataAnnotations;

namespace Platform_for_freelancing.Models
{
    public class Bid
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Сума ставки")]
        public decimal Amount { get; set; }

        [Display(Name = "Супровідний лист")]
        public string? CoverLetter { get; set; }

        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int FreelancerId { get; set; }
        public virtual Freelancer Freelancer { get; set; }
    }
}