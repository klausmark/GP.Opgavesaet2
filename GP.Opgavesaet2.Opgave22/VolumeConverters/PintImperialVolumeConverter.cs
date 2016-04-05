namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("pt (Imperial)")]
    public class PintImperialVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/568.26m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*568.26m;
        }
    }
}