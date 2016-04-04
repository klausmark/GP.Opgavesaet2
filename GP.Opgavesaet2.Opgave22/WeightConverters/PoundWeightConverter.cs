namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("lb")]
    public class PoundWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalWeight(decimal universalWeight)
        {
            return universalWeight/453.6m;
        }

        public decimal ConvertToUniversalWeight(decimal weight)
        {
            return weight*453.6m;
        }
    }
}