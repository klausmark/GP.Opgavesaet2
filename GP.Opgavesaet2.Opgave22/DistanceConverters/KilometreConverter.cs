namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("km")]
    public class KilometreConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance / 100000;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance * 100000;
        }
    }
}