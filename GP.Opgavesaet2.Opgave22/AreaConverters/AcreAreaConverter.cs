namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("acre")]
    public class AcreAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/4046.856m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*4046.856m;
        }
    }
}