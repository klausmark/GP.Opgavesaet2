namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("ft")]
    public class FootConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance * 30.48m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance / 30.48m;
        }
    }
}