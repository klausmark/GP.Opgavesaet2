namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("ft")]
    public class FootConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance / 0.3048m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance * 0.3048m;
        }
    }
}