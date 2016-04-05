namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("nm")]
    public class NauticalMileConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/1852m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*1852m;
        }
    }
}