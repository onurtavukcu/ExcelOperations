using System.Data;

namespace ExcelOperations.Operations.MinorOperations
{
    public class ChangeSameColumnName
    {
        public List<string> ChangeNameOps(List<string> row)
        {
            List<string> comparerList = row;

            var allIndexOf = Enumerable.Range(0, row.Count).Where(i => comparerList[i] == row[i]).Where(j => j > 1);

            foreach (var item in allIndexOf)
            {
                comparerList[item] = comparerList[item] + "1";
            }
            return comparerList;
        }
    }
}