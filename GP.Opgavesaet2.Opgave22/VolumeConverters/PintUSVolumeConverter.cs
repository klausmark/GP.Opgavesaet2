namespace GP.Opgavesaet2.Opgave22.VolumeConverters
{
    [ConverterInformation("pt (US)")]
    public class PintUSVolumeConverter : IVolumeConverter
    {
        public decimal ConvertFromUniversalValue(decimal universalValue)
        {
            return universalValue/473.184m;
        }

        public decimal ConvertToUniversalValue(decimal value)
        {
            return value*473.184m;
        }
    }
}