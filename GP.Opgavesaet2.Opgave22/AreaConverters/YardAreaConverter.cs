namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("yd\u00b2")]
    public class YardAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/0.836127m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*0.836127m;
        }
    }
}