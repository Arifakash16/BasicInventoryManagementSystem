using System.ComponentModel.DataAnnotations;

namespace BasicInventoryManagementSystem.Mapper.LoginMapper
{
    public class Login
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
