using System.ComponentModel.DataAnnotations;

namespace Diplom.Models
{
    public class UserLoginViewModel
    {
        public string Login { get; set; }
        public string HashPassword { get; set; }
    }
}
