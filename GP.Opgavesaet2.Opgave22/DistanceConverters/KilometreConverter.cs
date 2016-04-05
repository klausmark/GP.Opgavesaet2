namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("km")]
    public class KilometreConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue / 1000;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value * 1000;
        }
    }
}