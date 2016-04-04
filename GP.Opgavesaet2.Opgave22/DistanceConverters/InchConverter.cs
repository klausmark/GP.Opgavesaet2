namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("in")]
    public class InchConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalDistance(decimal universalDistance)
        {
            return universalDistance/0.0254m;
        }

        public decimal ConvertToUniversalDistance(decimal distance)
        {
            return distance*0.0254m;
        }
    }
}