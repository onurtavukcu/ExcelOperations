using ExcelOperations.Entities;

namespace ExcelOperations.DocEntity.UserInfo
{
    public class UserInput : IEntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string emailAddres { get; set; }
    }
}
