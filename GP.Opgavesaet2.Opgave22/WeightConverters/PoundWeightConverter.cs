namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("lb")]
    public class PoundWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/453.6m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*453.6m;
        }
    }
}