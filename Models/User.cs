using System.ComponentModel.DataAnnotations;

namespace formSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string firstName { get; set;}

        [Required]
        [MinLength(3)]
        public string lastName { get; set;}

        [Required]
        [Range(0, 100)]
        public int age {get; set;}

        [Required]
        [EmailAddress]
        public string email {get; set;}

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password {get; set;}


    }
}

