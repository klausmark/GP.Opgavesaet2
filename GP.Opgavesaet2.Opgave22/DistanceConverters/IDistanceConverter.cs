namespace GP.Opgavesaet2.Opgave22.DistanceConverters
{
    public interface IDistanceConverter
    {
        decimal ConvertFromUniversalDistance(decimal universalDistance);
        decimal ConvertToUniversalDistance(decimal distance);
    }
}
