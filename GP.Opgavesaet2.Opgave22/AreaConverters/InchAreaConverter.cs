namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    [ConverterInformation("in\u00b2")]
    public class InchAreaConverter : IAreaConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/0.000645m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*0.000645m;
        }
    }
}