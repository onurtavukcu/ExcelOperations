namespace ExcelOperations.DocEntity
{
    public class FileResourcePath
    {
        public const string RootPath = @"C:\Users\adm\Desktop\testexcel\Docs\";
        public const string RouterAktuell = $@"{RootPath}Aktuell\Router_aktuell.xlsx,RouterAktuell";
        public const string XWDMAktuell = $@"{RootPath}Aktuell\xWDM_aktuell.xlsx,XWDMAktuell";
        public const string LagerCentral = $@"{RootPath}Lagers\Lager Central 2023-02-23.xlsm,LagerCentral";
        public const string Cisco_PO = $@"{RootPath}PO\Project 2023-02-17.xlsx,Cisco_PO";
        public const string Deltatel_PO = $@"{RootPath}PO\Deltatel_PO.xlsx,Deltatel_PO";
        public const string ZTE_PO = $@"{RootPath}PO\DWM_Projeckt_2023-02-18.xlsx,ZTE_PO";
        public const string JSLMultiProject = $@"{RootPath}POC\POC_JSL_Multiprojekt_2.0_aktuell.xlsx,JSLMultiProject";
        public const string MultiProject = $@"{RootPath}POC\POC_Multiprojekt_2.0_aktuell.xlsx,MultiProject";
        public const string RouterSwapAktuell = $@"{RootPath}Aktuell\ROUTER_Swap_aktuell.xlsm,RouterSwapAktuell";
        public const string ZugangsdatenAktuell = $@"{RootPath}Zugang\Zugangsdaten_aktuell.xlsx,ZugangsdatenAktuell";
        public const string RouterAktuelOrderList = $@"{RootPath}Aktuell\Router_aktuell.xlsx,RouterAktuellOrderList";
        public const string XWDMAktuellOrderList = $@"{RootPath}Aktuell\xWDM_aktuell.xlsx,XWDMAktuellOrderList";

        public List<string> locationList = new List<string>
            {
                "RouterAktuell","XWDMAktuell","LagerCentral","Cisco_PO","Deltatel_PO","ZTE_PO","JSLMultiProject","MultiProject","RouterSwapAktuell","ZugangsdatenAktuell","RouterAktuelOrderList", "XWDMAktuellOrderList"
            };

        public new List<(string ,int )> locationList1 = new List<(string, int)>
        {
            ( RouterAktuell, 5),
            ( XWDMAktuell, 5),
            ( LagerCentral, 1),
            ( Cisco_PO, 1),
            ( Deltatel_PO, 1),
            ( ZTE_PO, 1),
            ( JSLMultiProject, 5),
            ( MultiProject, 4),
            ( RouterSwapAktuell, 5),
            ( ZugangsdatenAktuell, 5),
            ( RouterAktuelOrderList, 5),
            ( XWDMAktuellOrderList, 5)
        };

        public (string,int) MatchLocation(string loc)
        {
            foreach (var item in locationList1)
            {
                var splitted= item.Item1.Split(",");
                var fileName = splitted.Last();
                
                if (loc == fileName)
                {
                    return (splitted.First(), item.Item2);
                }
            }
            return ("Fail",2);
        }
    }
}
