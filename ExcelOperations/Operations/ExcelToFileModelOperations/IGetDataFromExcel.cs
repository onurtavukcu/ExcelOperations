namespace ExcelOperations.Operations.ExcelToFileModelOperations
{
    public interface IGetDataFromExcel<T>
    {
        Task<List<T>> GetDataFromExcelAsync(CancellationToken cancellationToken);
    }
}
