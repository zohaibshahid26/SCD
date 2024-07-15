using Microsoft.Extensions.ObjectPool;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class NotAllowedWordsAttribute : ValidationAttribute
    {
        private readonly string[] _notAllowedWords;

        public NotAllowedWordsAttribute(string[] NotAllowedWords)
        {
            _notAllowedWords = NotAllowedWords;
        }

        protected override ValidationResult? IsValid(object? value,
            ValidationContext validationContext)
        {

            foreach (var word in _notAllowedWords) {

                if (value.ToString().Contains(word)) {
                    return new ValidationResult("you entered not allowed word");
                }
            }
        
            return ValidationResult.Success;
        }
    }
}
