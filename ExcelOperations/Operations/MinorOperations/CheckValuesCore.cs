
using System.Data;

namespace ExcelOperations.Operations.MinorOperations
{
    public static class CheckValuesCore
    {
        public static bool CheckSameColumnName(DataRow dataRow)
        {
            for (int i = 0; i < dataRow.Table.Columns.Count; i++)
            {
                var columnValue = dataRow[i];

                if (true)
                {

                }
            }


            return true;
        }

    }
}
