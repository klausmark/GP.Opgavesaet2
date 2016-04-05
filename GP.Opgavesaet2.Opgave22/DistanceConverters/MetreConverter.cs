namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("m")]
    public class MetreConverter : IDistanceConverter
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