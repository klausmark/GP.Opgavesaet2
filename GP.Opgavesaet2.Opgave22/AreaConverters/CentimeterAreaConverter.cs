namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("cm\u00b2")]
    public class CentimeterAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue*10000;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value/10000;
        }
    }
}