namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("stone")]
    public class StoneWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/6350.4m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*6350.4m;
        }
    }
}