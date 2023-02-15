//using ExcelOperations.DocEntity;
//using System.Collections.Generic;
//using System.Reflection;


//namespace ExcelOperations.Operations
//{
//    public class PropertyOpes
//    {
//        public void opssss()
//        {
//            var propList = new List<string>();

//            var routerAktuellDataType = typeof(RouterAktuell);

//            var routerAktuellProperties = routerAktuellDataType.GetProperties();

//            foreach (var properties in routerAktuellProperties)
//            {
//                var attribute = properties.GetCustomAttribute<ColumnNameAttribute>();

//                var columnName = attribute is null
//                      ? properties.Name
//                      : attribute.Name;

//                propList.Add(columnName);
//            }


//            var routerSwapAktuellDataType = typeof(RouterSwapAktuell);

//            var routerSwapAktuellProperties = routerSwapAktuellDataType.GetProperties();

//            foreach (var properties in routerSwapAktuellProperties)
//            {
//                var attribute = properties.GetCustomAttribute<ColumnNameAttribute>();

//                var columnName = attribute is null
//                      ? properties.Name
//                      : attribute.Name;

//                propList.Add(columnName);
//            }

//            var XWDMAktuelIDataType = typeof(XWDMAktuell);

//            var XWDMAktuelIProperties = XWDMAktuelIDataType.GetProperties();

//            foreach (var properties in XWDMAktuelIProperties)
//            {
//                var attribute = properties.GetCustomAttribute<ColumnNameAttribute>();

//                var columnName = attribute is null
//                      ? properties.Name
//                      : attribute.Name;

//                propList.Add(columnName);
//            }

//            var ZugangDataType = typeof(ZugangsdatenAktuell);

//            var ZugangProperties = ZugangDataType.GetProperties();

//            foreach (var properties in ZugangProperties)
//            {
//                var attribute = properties.GetCustomAttribute<ColumnNameAttribute>();

//                var columnName = attribute is null
//                      ? properties.Name
//                      : attribute.Name;

//                propList.Add(columnName);
//            }

//            return pr
//        }
//    }
//}
