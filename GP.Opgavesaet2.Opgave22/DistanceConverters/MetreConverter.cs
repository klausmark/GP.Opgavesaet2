namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("m")]
    public class MetreConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance;
        }
    }
}