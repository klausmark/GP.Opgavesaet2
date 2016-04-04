namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    public interface IVolumeConverter
    {
        decimal ConvertFromUniversalVolume(decimal universalVolume);
        decimal ConvertToUniversalVolume(decimal distance);
    }
}