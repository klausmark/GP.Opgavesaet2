namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("fl oz (Imperial)")]
    public class FluidOunceImperialVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/28.413m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*28.413m;
        }
    }
}