namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("cm")]
    public class CentimetreConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue * 100m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value / 100m;
        }
    }
}