namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("cm")]
    public class CentimetreConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance * 100m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance / 100m;
        }
    }
}