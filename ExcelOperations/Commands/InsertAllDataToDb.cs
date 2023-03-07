using ExcelOperations.Context;
using ExcelOperations.Operations;
using ExcelOperations.Operations.ExcelToFileModelOperations.Lager;
using ExcelOperations.Operations.ExcelToFileModelOperations.PO;
using ExcelOperations.Operations.ExcelToFileModelOperations.POC;

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

            var excelReader = new RouterAktuell_ExcelFileToModels();

            var result = await excelReader.RouterAktuellAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result, cancellationToken);


            var excelReader1 = new ZTE_ExcelFileToModels();

            var result1 = await excelReader1.ZTEPOAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result1, cancellationToken);

            var resultCount1 = result1.Count();


            var excelReader2 = new Deltatel_ExcelFileToModels();

            var result2 = await excelReader2.DeltatelPOAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result2, cancellationToken);

            var resultCount2 = result2.Count();


            var excelReader3 = new ZugangsdatenAktuell_ExcelFileToModel();

            var result3 = await excelReader3.ZugangsdatenAktuellAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result3, cancellationToken);

            var resultCount = result.Count();


            var excelReader4 = new XWDMAktuel_ExcelFileToModels();

            var result4 = await excelReader4.XWDMAktuellAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result4, cancellationToken);


            var excelReader5 = new RouterSwapAktuell_ExcelFileToModels();

            var result5 = await excelReader5.RouterSwapAktuellAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result5, cancellationToken);


            var excelReader6 = new JSLMultiProject_ExcelFileToModels();

            var result6 = await excelReader6.JSLMultiProjectAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result6, cancellationToken);



            var excelReader7 = new MultiProject_ExcelFileToModels();

            var result7 = await excelReader7.MultiProjectAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result7, cancellationToken);


            var excelReader8 = new Lagers_ExcelFileToModels();

            var result8 = await excelReader8.LagerAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result8, cancellationToken);


            var excelReader9 = new Cisco_ExcelFileToModels();

            var result9 = await excelReader9.CiscoPOAsync(cancellationToken);

            await _EntityDbContext.BulkInsertAsync(result9, cancellationToken);

            return;
        }

    }
}
