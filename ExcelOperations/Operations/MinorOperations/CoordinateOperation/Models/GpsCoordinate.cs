namespace ExcelOperations.Operations.MinorOperations.CoordinateOperation.NewFolder.Models
{
    public class GpsCoordinate
    {
        public Coordinate east { get; set; }
        public Coordinate north { get; set; }
    }

    public class Coordinate
    {
        public int degree { get; set; }
        public int minute { get; set; }
        public float second { get; set; }
    }
}
