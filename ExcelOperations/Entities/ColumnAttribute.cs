namespace ExcelOperations.DocEntity
{
    public class ColumnNameAttribute : Attribute
    {
        public ColumnNameAttribute(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}
