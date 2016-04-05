namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("mi\u00b2")]
    public class MileAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/2589988;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*2589988;
        }
    }
}