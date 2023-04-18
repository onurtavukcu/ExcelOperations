using ExcelOperations.Context;
using ExcelOperations.DocEntity;
using ExcelOperations.DocEntity.Aktuell;
using ExcelOperations.DocEntity.Entity.Aktuell;
using ExcelOperations.DocEntity.Entity.Lager;
using ExcelOperations.DocEntity.Entity.PO;
using ExcelOperations.DocEntity.Entity.POC;
using ExcelOperations.DocEntity.Entity.Zugang;
using ExcelOperations.DocEntity.PO;
using ExcelOperations.Operations.ExcelToFileModelOperations;

namespace ExcelOperations.Commands
{
    public class InsertAllDataToDb
    {
        private readonly EntityDbContext _EntityDbContext;
        
        public InsertAllDataToDb(EntityDbContext entityDbContext)
        {
            _EntityDbContext = entityDbContext;
        }

        public async Task InsertDataAsync(CancellationToken cancellationToken)
        {
            var excelReader = new ExcelFileToModelOps<RouterAktuell>();

            var result = await excelReader.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);


            var excelReader1 = new ExcelFileToModelOps<ZTE_PO>();

            var result1 = await excelReader1.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result1, cancellationToken);

            var resultCount1 = result1.Count();


            var excelReader2 = new ExcelFileToModelOps<Deltatel_PO>();

            var result2 = await excelReader2.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result2, cancellationToken);

            var resultCount2 = result2.Count();


            var excelReader3 = new ExcelFileToModelOps<ZugangsdatenAktuell>();

            var result3 = await excelReader3.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result3, cancellationToken);

            var resultCount = result.Count();


            var excelReader4 = new ExcelFileToModelOps<XWDMAktuell>();

            var result4 = await excelReader4.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result4, cancellationToken);


            var excelReader5 = new ExcelFileToModelOps<RouterSwapAktuell>();

            var result5 = await excelReader5.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result5, cancellationToken);


            var excelReader6 = new ExcelFileToModelOps<JSLMultiProject>();

            var result6 = await excelReader6.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result6, cancellationToken);



            var excelReader7 = new ExcelFileToModelOps<MultiProject>();

            var result7 = await excelReader7.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result7, cancellationToken);


            var excelReader8 = new ExcelFileToModelOps<LagerCentral>();

            var result8 = await excelReader8.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result8, cancellationToken);


            var excelReader9 = new ExcelFileToModelOps<Cisco_PO>();

            var result9 = await excelReader9.GetDataFromExcelAsync(0, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result9, cancellationToken);


            var excelReader10 = new ExcelFileToModelOps<RouterAktuellOrderList>();

            var result10 = await excelReader9.GetDataFromExcelAsync(1, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result9, cancellationToken);


            var excelReader111 = new ExcelFileToModelOps<XWDMAktuellOrderList>();

            var result111 = await excelReader9.GetDataFromExcelAsync(1, cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result9, cancellationToken);

            return;
        }

    }
}
