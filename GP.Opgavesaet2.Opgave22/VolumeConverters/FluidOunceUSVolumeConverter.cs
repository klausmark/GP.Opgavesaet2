namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("fl oz (US)")]
    public class FluidOunceUSVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/29.574m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*29.574m;
        }
    }
}