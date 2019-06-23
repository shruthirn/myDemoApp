using System.ComponentModel.DataAnnotations;

namespace myDemoApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Please enter password between 8 to 4 Characters only")]
         public string Password { get; set; }

    }
}