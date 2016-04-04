namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("mi\u00b2")]
    public class MileAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea/2589988;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area*2589988;
        }
    }
}