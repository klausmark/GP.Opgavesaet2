namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("g")]
    public class GramWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value;
        }
    }
}