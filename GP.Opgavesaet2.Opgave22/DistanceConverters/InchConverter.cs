namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [DistanceConverterInformation("in")]
    public class InchConverter : IDistanceConverter
    {
        public decimal ConvertFrom(decimal universalDistance)
        {
            return universalDistance * 2.54m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance / 2.54m;
        }
    }
}