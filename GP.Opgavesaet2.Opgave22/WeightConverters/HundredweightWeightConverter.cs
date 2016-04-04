namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("cwt")]
    public class HundredweightWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalWeight(decimal universalWeight)
        {
            return universalWeight/117244.8m;
        }

        public decimal ConvertToUniversalWeight(decimal weight)
        {
            return weight*117244.8m;
        }
    }
}