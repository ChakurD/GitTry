using System.ComponentModel.DataAnnotations;

namespace WebLesson15._1.Models
{
    public class RegistrationModel
    {
        //[Phone]
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Name { get; set; }

        //[CreditCard]
        [Required]
        public int Age { get; set; }

        [Required]
<<<<<<< Updated upstream
        [Range(5,15)]
=======
        //[Range(5,15)]
>>>>>>> Stashed changes
        public string Password { get; set; }

        [Required]
        public string Login { get; set; }

<<<<<<< Updated upstream
        [EmailAddress]
=======
        //[EmailAddress]
>>>>>>> Stashed changes
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength (5)]
        public string Country { get; set; }

        public RegistrationModel() { }

        public RegistrationModel(string surname, string name,string password, string email, string country, int age, string login)
        {
            Surname = surname;
            Name = name;
            Email = email;
            Country = country;
            Password = password;
            Age = age;
            Login = login;
        }


    }
}