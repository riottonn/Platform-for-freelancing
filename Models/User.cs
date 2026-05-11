using System.ComponentModel.DataAnnotations;

namespace Platform_for_freelancing.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Пароль")]
        public string PasswordHash { get; set; }

        [Display(Name = "Повне ім'я")]
        public string? FullName { get; set; }
    }
}
