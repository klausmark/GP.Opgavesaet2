namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("m")]
    public class MetreConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance / 100;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance * 100;
        }
    }
}