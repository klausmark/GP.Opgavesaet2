namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("gallon (Imperial)")]
    public class GallonImperialVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/4546.08m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*4546.08m;
        }
    }
}