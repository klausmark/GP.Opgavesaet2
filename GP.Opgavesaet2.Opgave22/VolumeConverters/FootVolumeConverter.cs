namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("ft\u00b3")]
    public class FootVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/28316.736m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*28316.736m;
        }
    }
}