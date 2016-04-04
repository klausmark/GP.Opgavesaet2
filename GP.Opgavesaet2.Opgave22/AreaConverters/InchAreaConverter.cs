namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("in\u00b2")]
    public class InchAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea/0.000645m;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area*0.000645m;
        }
    }
}