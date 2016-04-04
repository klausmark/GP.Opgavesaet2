namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("yd")]
    public class YardConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance * 91.44m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance / 91.44m;
        }
    }
}