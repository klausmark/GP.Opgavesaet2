namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("ton")]
    public class TonWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/14224896;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*14224896;
        }
    }
}