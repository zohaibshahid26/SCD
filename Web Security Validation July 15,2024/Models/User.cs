using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [NotAllowedWordsAttribute(new string[] { "abc"})]
        [Required(ErrorMessage ="please enter your name")]
        public string Name { get; set; }


        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
