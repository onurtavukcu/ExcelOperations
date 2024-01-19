using ExcelOperations.Entities;
using ExcelOperations.Entities.DocEntity;
using ExcelOperations.Operations.ExcelToFileModelOperations;
using ExcelOperations.Repository.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExcelOperations.Commands
{
    public class InsertAllDataToDbCommand
    {
        //private readonly EntityDbContext _EntityDbContext;

        private readonly IUnitOfWork _unitOfWork;

        public InsertAllDataToDbCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
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

                if (invocationTask is null)
                    continue;

                await invocationTask;

                var taskType = methodInfo.ReturnType;

                var resultProperty = taskType.GetProperty("Result");

                if (resultProperty is null)
                    continue;

                var invocationResult = resultProperty.GetValue(invocationTask) as IEnumerable<object>;

                await _unitOfWork.DbContext.BulkInsertAsync(invocationResult, cancellationToken);
            }

            //var excelReader = new ExcelFileToModelOps<RouterAktuellOrderList>();

            //var result = await excelReader.GetDataFromExcelAsync(1, cancellationToken);

            //await _EntityDbContext.BulkInsertAsync(result, cancellationToken);
        }
    }
}
