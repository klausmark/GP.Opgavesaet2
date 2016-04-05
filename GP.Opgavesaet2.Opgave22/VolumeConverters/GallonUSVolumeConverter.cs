namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("gallon (US)")]
    public class GallonUSVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/3785.472m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*3785.472m;
        }
    }
}