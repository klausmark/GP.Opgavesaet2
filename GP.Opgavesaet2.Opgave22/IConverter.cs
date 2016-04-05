namespace GP.Opgavesaet2.Opgave22
{
    public interface IConverter
    {
        decimal ConvertFromUniversalValue(decimal universalValue);
        decimal ConvertToUniversalValue(decimal value);
    }
}