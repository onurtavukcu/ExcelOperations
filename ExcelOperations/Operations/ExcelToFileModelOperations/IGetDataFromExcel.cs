namespace ExcelOperations.Operations.ExcelToFileModelOperations
{
    public interface IGetDataFromExcel<T>
    {
        Task<List<T>> GetDataFromExcelAsync(int tableNumber, CancellationToken cancellationToken);
    }
}
