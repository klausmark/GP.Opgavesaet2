namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("in")]
    public class InchConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/0.0254m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*0.0254m;
        }
    }
}