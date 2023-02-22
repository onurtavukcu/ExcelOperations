//using ExcelOperations.Context;
//using ExcelOperations.DocEntity;
//using Microsoft.AspNetCore.Mvc;

//namespace ExcelOperations.Commands
//{
//    public class GetSomeMotherFuckerEntity
//    {
//        private readonly EntityDbContext _entityDbContext;

//        public IEnumerable<RouterAktuell> RouterAktuellGetDataAsync()
//        {
//            var routerAktuellsList = _entityDbContext.RouterAktuell;

//            //var result = routerAktuellsList.Where(i => i.CtK_Status.Contains("onurt"));
            
//            try
//            {
//                return routerAktuellsList.AsQueryable();
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.Message);
//            }
//        }

//        public Task<IEnumerable<RouterAktuell>> RouterAktuellDeleteDataAsync()
//        {
//            var routerAktuellsList = _entityDbContext.RouterAktuell;

//            return Task.FromResult(routerAktuellsList.AsEnumerable());
//        }
//    }
//}
