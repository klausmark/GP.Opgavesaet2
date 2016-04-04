namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("km\u00b2")]
    public class KilometerAreaConverter : IAreaConverter
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