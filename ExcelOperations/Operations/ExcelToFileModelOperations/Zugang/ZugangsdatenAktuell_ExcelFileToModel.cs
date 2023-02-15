﻿using ExcelOperations.DocEntity;
using ExcelOperations.Operations.MinorOperations;
using System.Data;
using System.Reflection;

namespace ExcelOperations.Operations
{
    public class ZugangsdatenAktuell_ExcelFileToModel
    {
        public async Task<List<ZugangsdatenAktuell>> ZugangsdatenAktuellAsync(CancellationToken cancellationToken)
        {
            string fileLocation = @"C:\Users\adm\Desktop\testexcel\Docs\Zugang\Zugangsdaten_aktuell.xlsx";

            var datasetOperations = new ExcelToDataSet();

            var datasets = datasetOperations.TakeExcelToDataset(fileLocation, 5,cancellationToken);

            var dataList = new List<ZugangsdatenAktuell>();

            var dataTypes = typeof(ZugangsdatenAktuell);

            var properties = dataTypes.GetProperties();

            foreach (DataRow row in datasets.Result.Tables[0].Rows)
            {
                var modelInstance = new ZugangsdatenAktuell();

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
            return await Task.FromResult(dataList);
        }
    }
}