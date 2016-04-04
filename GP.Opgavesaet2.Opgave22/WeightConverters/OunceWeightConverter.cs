namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("oz")]
    public class OunceWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalWeight(decimal universalWeight)
        {
            return universalWeight/28.35m;
        }

        public decimal ConvertToUniversalWeight(decimal weight)
        {
            return weight*28.35m;
        }
    }
}