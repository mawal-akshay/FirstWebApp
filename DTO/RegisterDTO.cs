using System.ComponentModel.DataAnnotations;

namespace MVCApp.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Name is required")]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Email cant be blank")]
        [EmailAddress(ErrorMessage ="Email should be in a proper email address format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone cant be blank")]
        [RegularExpression("^[0-9]*$", ErrorMessage ="Phone number should contain numbers only")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Password cant be blank")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "ConfirmPassword cant be blank")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
