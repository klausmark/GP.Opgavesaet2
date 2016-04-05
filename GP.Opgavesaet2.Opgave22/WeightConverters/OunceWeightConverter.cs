namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    [ConverterInformation("oz")]
    public class OunceWeightConverter : IWeightConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/28.35m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*28.35m;
        }
    }
}