using System.ComponentModel.DataAnnotations;

namespace Yopeso.Auth.Lib.Contracts
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "User Name is required")]  
        public string Username { get; set; }  
  
        [Required(ErrorMessage = "Password is required")]  
        public string Password { get; set; }  
    }
}