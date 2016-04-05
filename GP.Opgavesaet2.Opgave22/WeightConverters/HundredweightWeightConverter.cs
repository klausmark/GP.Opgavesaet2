namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("cwt")]
    public class HundredweightWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/117244.8m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*117244.8m;
        }
    }
}