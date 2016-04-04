namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("nm")]
    public class NauticalMileConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance/1852m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance*1852m;
        }
    }
}