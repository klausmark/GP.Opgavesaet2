namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("g")]
    public class GramWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalWeight(decimal universalWeight)
        {
            return universalWeight;
        }

        public decimal ConvertToUniversalWeight(decimal weight)
        {
            return weight;
        }
    }
}