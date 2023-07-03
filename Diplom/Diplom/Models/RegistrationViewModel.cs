using Diplom.DataAccess.Entity;
using System.ComponentModel.DataAnnotations;

namespace Diplom.Models
{
    public class RegistrationViewModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string JobTittle { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password not specified")]
        [Compare("Password", ErrorMessage = "Password entered is incorrect")]
        public string ConfirmPassword { get; set; }
        public int? StorageWorkersId { get; set; }
        public IEnumerable<StorageWorkers>? StorageWorkers { get; set; }
        public IEnumerable<Storage>? Storages { get; set; }
    }
}
