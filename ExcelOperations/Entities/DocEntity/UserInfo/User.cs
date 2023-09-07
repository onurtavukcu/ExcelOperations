using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcelOperations.Entities.DocEntity.UserInfo
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public UserType UserType { get; set; }
        [ForeignKey(nameof(UserType))]
        public int UserTypeId { get; set; }


        //public User(string username, string passwordHash, UserType userType)
        //{
        //    UserType = userType;
        //    Username = username;    
        //    PasswordHash = passwordHash;
        //}
    }
}
