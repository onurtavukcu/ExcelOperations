using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcelOperations.Entities.UserInfo
{
    public class UserType
    {
        [Key, ForeignKey("User")]
        public int id { get; set; }
        public UserTypeEnums role { get; set; }
    }
}
