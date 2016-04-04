namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("acre")]
    public class AcreAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalArea(decimal universalArea)
        {
            return universalArea/4046.856m;
        }

        public decimal ConvertToUniversalArea(decimal area)
        {
            return area*4046.856m;
        }
    }
}