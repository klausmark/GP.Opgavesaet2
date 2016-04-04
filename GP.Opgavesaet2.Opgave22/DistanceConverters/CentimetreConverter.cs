namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("cm")]
    public class CentimetreConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance;
        }
    }
}