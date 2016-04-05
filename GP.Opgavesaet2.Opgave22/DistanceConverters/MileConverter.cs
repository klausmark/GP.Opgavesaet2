namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("mi")]
    public class MileConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/1609.344m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*1609.344m;
        }
    }
}