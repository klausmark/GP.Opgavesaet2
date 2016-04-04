namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("cm\u00b2")]
    public class CentimeterAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea*10000;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area/10000;
        }
    }
}