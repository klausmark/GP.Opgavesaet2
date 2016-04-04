namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("mi")]
    public class MileConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance * 160934.4m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance / 160934.4m;
        }
    }
}