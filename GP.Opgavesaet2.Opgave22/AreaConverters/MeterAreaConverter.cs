namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("m\u00b2")]
    public class MeterAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area;
        }
    }
}