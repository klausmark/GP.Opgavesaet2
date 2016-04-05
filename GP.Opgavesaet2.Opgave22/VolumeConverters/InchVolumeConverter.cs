namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("in\u00b3")]
    public class InchVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/16.387m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*16.387m;
        }
    }
}