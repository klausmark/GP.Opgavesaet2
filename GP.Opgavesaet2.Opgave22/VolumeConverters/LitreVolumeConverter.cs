namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("l")]
    public class LitreVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/1000;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*1000;
        }
    }
}