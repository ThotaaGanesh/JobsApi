using System.ComponentModel.DataAnnotations;

namespace JobsApi.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string PhoneNumber { get; set; }
        public required RoleViewModel Role { get; set; }
    }


}
