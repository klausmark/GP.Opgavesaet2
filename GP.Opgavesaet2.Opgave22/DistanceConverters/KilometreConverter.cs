namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("km")]
    public class KilometreConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance / 1000;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance * 1000;
        }
    }
}