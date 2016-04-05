namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    [ConverterInformation("yd")]
    public class YardConverter : IDistanceConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/0.9144m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*0.9144m;
        }
    }
}