using ExcelOperations.Entities;
using System.ComponentModel.DataAnnotations;

namespace ExcelOperations.DocEntity.UserInfo
{
    public class UserInput
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
