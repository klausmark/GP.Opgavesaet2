namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("m\u00b2")]
    public class MeterAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value;
        }
    }
}