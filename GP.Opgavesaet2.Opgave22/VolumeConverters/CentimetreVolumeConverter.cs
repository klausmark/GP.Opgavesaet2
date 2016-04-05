namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("cm\u00b3")]
    public class CentimetreVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value;
        }
    }
}