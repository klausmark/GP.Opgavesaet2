namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("nm")]
    public class NauticalMileConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance*185202.576m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance/185202.576m;
        }
    }
}