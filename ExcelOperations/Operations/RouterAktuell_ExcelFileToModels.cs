﻿using ExcelDataReader;
using ExcelOperations.DocEntity;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations
{
    public class RouterAktuell_ExcelFileToModels
    {
        public List<RouterAktuell> ExcelTables()
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\Router_aktuell.xlsx";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation,5);

            var dataList = new List<RouterAktuell>();

            var dataTypes = typeof(RouterAktuell);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Tables[0].Rows)
            {
                var modelInstance = new RouterAktuell();

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
                        property.SetValue(modelInstance, data.ToString());
                    }
                }

                dataList.Add(modelInstance);
            }
            return dataList;
        }       
    }
}
