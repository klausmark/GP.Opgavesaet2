namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("ton")]
    public class TonWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalWeight(decimal universalWeight)
        {
            return universalWeight/14224896;
        }

        public decimal ConvertToUniversalWeight(decimal weight)
        {
            return weight*14224896;
        }
    }
}