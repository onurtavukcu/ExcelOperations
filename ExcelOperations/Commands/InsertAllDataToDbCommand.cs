using Castle.Components.DictionaryAdapter.Xml;
using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.Entity.Zugang;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.Entities;
using ExcelOperations.Entities.DocEntity;
using ExcelOperations.Operations.ExcelToFileModelOperations;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using System.Collections;
using System.Reflection;

namespace ExcelOperations.Commands
{
    public class InsertAllDataToDb
    {
        private readonly EntityDbContext _EntityDbContext;
        private readonly IAllEntities _allEntities;

        public InsertAllDataToDb(EntityDbContext entityDbContext)
        {
            _EntityDbContext = entityDbContext;
        }

        public async Task InsertDataAsync(CancellationToken cancellationToken)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            Type[] interfaceImplementingTypes = types
                .Where(t => typeof(IEntityBase).IsAssignableFrom(t) && !t.IsAbstract && !t.IsInterface)
                .ToArray();

            var genericExcelReaderType = typeof(ExcelFileToModelOps<>);

            foreach (Type item in interfaceImplementingTypes)
            {
                var excelReaderType = genericExcelReaderType.MakeGenericType(item);
                var excelReaderInstance = Activator.CreateInstance(excelReaderType);

                if (excelReaderInstance is null)
                    continue;

                var methodInfo = excelReaderType.GetMethod("GetDataFromExcelAsync");

                if (methodInfo is null)
                    continue;

                var invocationTask = methodInfo.Invoke
                (
                    excelReaderInstance,
                    new object[]
                    {
                        EntityBase.GetTableNumber(item),
                        cancellationToken
                    }
                ) as Task;

                if(invocationTask is null )
                    continue;

                await invocationTask;

                var taskType = methodInfo.ReturnType;

                var resultProperty = taskType.GetProperty("Result");

                if(resultProperty is null)
                    continue;

                var invocationResult = resultProperty.GetValue(invocationTask) as IEnumerable<object>;

                await _EntityDbContext.BulkInsertAsync(invocationResult, cancellationToken);
            }






            //var excelReader = new ExcelFileToModelOps<RouterAktuell>();

            //var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result, cancellationToken);


            //Assembly assembly = Assembly.GetExecutingAssembly();

            //Type[] types = assembly.GetTypes();

            //Type[] interfaceImplementingTypes = types.Where(t => typeof(IEntityBase).IsAssignableFrom(t)).ToArray();

            //foreach (Type type in interfaceImplementingTypes)
            //{
            //    var excelReaders = new ExcelFileToModelOps<type>();

            //    var results = await excelReaders.GetDataFromExcelAsync(0, cancellationToken);

            //    await _EntityDbContext.BulkInsertAsync(results, cancellationToken);
            //}

            //var instance = new Entities();
            //Type type = typeof(Entities);

            //Dictionary<string, object> properties = new Dictionary<string, object>();
            //foreach (PropertyInfo prop in type.GetProperties())
            //    properties.Add(prop.Name, prop.GetValue(instance));


            //var typeList  = new List<Type>();
            //foreach (PropertyInfo props in type.GetProperties())
            //{
            //    typeList.Add((Type)props.GetValue(instance));
            //}
            //var sdass = typeList;
            //foreach (var types in typeList)
            //{
            //    var excelReader = new ExcelFileToModelOps<types>();

            //    var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            //    await _EntityDbContext.BulkInsertAsync(result, cancellationToken);
            //}


            //var excelReader = new ExcelFileToModelOps<RouterAktuell>();

            //var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result, cancellationToken);


            //var excelReader1 = new ExcelFileToModelOps<ZTE_PO>();

            //var result1 = await excelReader1.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result1, cancellationToken);


            //var excelReader2 = new ExcelFileToModelOps<Deltatel_PO>();

            //var result2 = await excelReader2.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result2, cancellationToken);


            //var excelReader3 = new ExcelFileToModelOps<ZugangsdatenAktuell>();

            //var result3 = await excelReader3.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result3, cancellationToken);


            //var excelReader4 = new ExcelFileToModelOps<XWDMAktuell>();

            //var result4 = await excelReader4.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result4, cancellationToken);


            //var excelReader5 = new ExcelFileToModelOps<RouterSwapAktuell>();

            //var result5 = await excelReader5.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result5, cancellationToken);


            //var excelReader6 = new ExcelFileToModelOps<JSLMultiProject>();

            //var result6 = await excelReader6.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result6, cancellationToken);


            //var excelReader7 = new ExcelFileToModelOps<MultiProject>();

            //var result7 = await excelReader7.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result7, cancellationToken);


            //var excelReader8 = new ExcelFileToModelOps<LagerCentral>();

            //var result8 = await excelReader8.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result8, cancellationToken);


            //var excelReader9 = new ExcelFileToModelOps<Cisco_PO>();

            //var result9 = await excelReader9.GetDataFromExcelAsync(0, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result9, cancellationToken);


            //var excelReader10 = new ExcelFileToModelOps<RouterAktuellOrderList>();

            //var result10 = await excelReader10.GetDataFromExcelAsync(1, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result10, cancellationToken);


            //var excelReader11 = new ExcelFileToModelOps<XWDMAktuellOrderList>();

            //var result11 = await excelReader11.GetDataFromExcelAsync(1, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result11, cancellationToken);

            //return;
        }
    }
}
