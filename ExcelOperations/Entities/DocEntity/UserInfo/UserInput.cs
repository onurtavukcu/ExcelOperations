using ExcelOperations.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExcelOperations.DocEntity.UserInfo
{
    public class UserInput : IEntityBase
    {
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public string emailAddres { get; set; }
    }
}
