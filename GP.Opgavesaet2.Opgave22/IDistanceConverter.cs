namespace GP.Opgavesaet2.Opgave22
{
    public interface IDistanceConverter
    {
        decimal ConvertFrom(decimal universalDistance);
        decimal ConvertToUniversalDistance(decimal distance);
    }
}
