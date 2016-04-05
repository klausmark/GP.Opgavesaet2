namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("km\u00b2")]
    public class KilometerAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/1000000;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*1000000;
        }
    }
}