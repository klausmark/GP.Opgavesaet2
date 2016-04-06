namespace GP.Opgavesaet2.Opgave22.Converters
{
    public class RatiosAndInfo
    {
        public RatiosAndInfo(IRatios ratios, RatiosInfoAttribute ratiosInfoAttribute)
        {
            Ratios = ratios;
            RatiosInfoAttribute = ratiosInfoAttribute;
        }

        public IRatios Ratios { get; }
        public RatiosInfoAttribute RatiosInfoAttribute { get; }
    }
}