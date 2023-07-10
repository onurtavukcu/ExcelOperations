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
using ExcelOperations.Operations.ExcelToFileModelOperations;
using System.Reflection;

namespace ExcelOperations.Commands
{
    public class InsertAllDataToDb
    {
        private readonly EntityDbContext _EntityDbContext;
        
        public InsertAllDataToDb(EntityDbContext entityDbContext)
        {
            _EntityDbContext = entityDbContext;
        }

        public class Entities
        {
            public static RouterAktuell routerAktuell { get; set; }
            public static RouterAktuellOrderList routerAktuellOrdersList { get; set; }
            public static XWDMAktuell XWDMAktuell { get; set; }
            public static XWDMAktuellOrderList XWDMaktuellOrderList { get; set; }
        }

        public async Task InsertDataAsync(CancellationToken cancellationToken)
        {
            //Assembly assembly = Assembly.GetExecutingAssembly();

            //Type[] types = assembly.GetTypes();

            //Type[] interfaceImplementingTypes = types.Where(t => typeof(IEntityBase).IsAssignableFrom(t)).ToArray();

            //foreach (var modelType in interfaceImplementingTypes)
            //{
            //    var excelReaderType = typeof(ExcelFileToModelOps<>).MakeGenericType(modelType);
            //    dynamic excelReader = Activator.CreateInstance(excelReaderType);

            //    var getDataMethod = excelReaderType.GetMethod("GetDataFromExcelAsync");
            //    var result = await (Task<object>)getDataMethod.Invoke(excelReader, new object[] { 0, cancellationToken });

            //    var bulkInsertMethod = _EntityDbContext.GetType().GetMethod("BulkInsertAsync").MakeGenericMethod(modelType);
            //    await (Task)bulkInsertMethod.Invoke(_EntityDbContext, new object[] { result, cancellationToken });
            //}


                var modelTypes = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => t.IsClass && !t.IsAbstract && t.Namespace == "IEntityBase");

                foreach (var modelType in modelTypes)
                {
                    var excelReaderType = typeof(ExcelFileToModelOps<>).MakeGenericType(modelType);
                    dynamic excelReader = Activator.CreateInstance(excelReaderType);

                    var getDataMethod = excelReaderType.GetMethod("GetDataFromExcelAsync");
                    var result = await (Task<object>)getDataMethod.Invoke(excelReader, new object[] { 0, cancellationToken });

                    var bulkInsertMethod = _EntityDbContext.GetType().GetMethod("BulkInsertAsync").MakeGenericMethod(modelType);
                    await (Task)bulkInsertMethod.Invoke(_EntityDbContext, new object[] { result, cancellationToken });
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
