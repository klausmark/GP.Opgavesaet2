namespace GP.Opgavesaet2.Opgave22.WeightConverters
{
    public interface IWeightConverter
    {
        decimal ConvertFromUniversalWeight(decimal universalWeight);
        decimal ConvertToUniversalWeight(decimal weight);
    }
}