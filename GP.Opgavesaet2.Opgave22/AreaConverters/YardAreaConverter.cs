namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("yd\u00b2")]
    public class YardAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea/0.836127m;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area*0.836127m;
        }
    }
}