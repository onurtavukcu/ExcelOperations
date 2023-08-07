using System.ComponentModel.DataAnnotations;

namespace ExcelOperations.Entities.DocEntity.UserInfo
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public byte[] passwordHash { get; set; }        
    }
}
