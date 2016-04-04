namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("stone")]
    public class StoneWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalWeight(decimal universalWeight)
        {
            return universalWeight/6350.4m;
        }

        public decimal ConvertToUniversalWeight(decimal weight)
        {
            return weight*6350.4m;
        }
    }
}