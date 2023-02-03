using ExcelDataReader;
using ExcelOperations.DocEntity;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations
{
    public class RouterAktuell_ExcelFileToModels
    {
        public List<RouterAktuell> ExcelTables()
        {
            var datasets = TakeExcelToDataset();

            var dataList = new List<RouterAktuell>();

            var routerAktuellType = typeof(RouterAktuell);

            var properties = routerAktuellType.GetProperties();

            foreach (DataRow row in datasets.Tables[0].Rows)
            {
                var routerAktuellInstance = new RouterAktuell();

                foreach (var property in properties)
                {
                    var attribute = property.GetCustomAttribute<ColumnNameAttribute>();

                    var columnName = attribute is null
                        ? property.Name
                        : attribute.Name;

                    var data = row[columnName];

                    if (data is null || data == DBNull.Value)
                        continue;

                    if (property.CanWrite)
                    {
                        property.SetValue(routerAktuellInstance, data.ToString());
                    }
                }

                dataList.Add(routerAktuellInstance);
            }
            return dataList;
        }

        public DataSet TakeExcelToDataset()
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\Router_aktuell.xlsx";
            
            DataSet ds = new DataSet();

            FileStream fileStream = File.Open(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(fileStream);

            ds = reader.AsDataSet();

            return FirstRowToColumnName(ds,5);
        }

        public DataSet FirstRowToColumnName(DataSet dataSet, int rowCount)
        {
            DataRow row = dataSet.Tables[0].Rows[rowCount-1];  //4 for routerAktuell

            var columnCount = dataSet.Tables[0].Columns.Count;

            for (int i = 0; i < columnCount; i++)
            {
                dataSet.Tables[0].Columns[i].ColumnName = row[i].ToString();  //same Column Name give exception
            }

            dataSet.AcceptChanges();

            for (int i = 0; i < rowCount; i++)
            {
                dataSet.Tables[0].Rows[i].Delete();
            }

            dataSet.AcceptChanges();

            return dataSet;
        }
    }
}
