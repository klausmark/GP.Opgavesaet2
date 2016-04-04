namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("yd")]
    public class YardConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance/0.9144m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance*0.9144m;
        }
    }
}