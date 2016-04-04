namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    public class SquareKilometerAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea/1000000;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area*1000000;
        }
    }
}