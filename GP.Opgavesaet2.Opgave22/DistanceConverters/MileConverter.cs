namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("mi")]
    public class MileConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance/1609.344m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance*1609.344m;
        }
    }
}