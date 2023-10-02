using System.ComponentModel.DataAnnotations;

namespace MyWebApplication.Models.ViewModel
{
    public class RegUserModel
    {
        [Key]
        public int user_id { get; set; }

        public string Fullname { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Fullname")]
        public string Username { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Username")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Email")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Password")]
        public string Birthdate { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Birthdate")]
        public int Created_at { get; set; }
    }

}
