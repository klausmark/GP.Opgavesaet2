namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("ft")]
    public class FootConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue / 0.3048m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value * 0.3048m;
        }
    }
}