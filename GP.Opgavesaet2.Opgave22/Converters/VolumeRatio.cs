namespace GP.Opgavesaet2.Opgave22.Converters
{
    [RatiosInfo("Rumfang")]
    public class VolumeRatios : IRatios
    {
        public UniversalRatio[] GetRatios()
        {
            return new[]
            {
                new UniversalRatio("Kubikcentimeter", "cm\u00b3", 1m),
                new UniversalRatio("Milliliter", "ml", 1m),
                new UniversalRatio("Liter", "l", 1000m),
                new UniversalRatio("Kubikmeter", "m\u00b3", 1000000m),
                new UniversalRatio("Cubic inch", "in\u00b3", 16.387m),
                new UniversalRatio("Cubic foot", "ft\u00b3", 28316.736m),
                new UniversalRatio("Fluid ounce (Imperial)", "fl oz (Imperial)", 28.413m),
                new UniversalRatio("Fluid ounce (US)", "fl oz (US)", 29.574m),
                new UniversalRatio("Pint (Imperial)", "pt (Imperial)", 568.26m),
                new UniversalRatio("Pint (US)", "pt (US)", 473.184m),
                new UniversalRatio("Gallon (Imperial)", "gallon (Imperial)", 4546.08m),
                new UniversalRatio("Gallon (US)", "gallon (US)", 3785.472m),
            };
        }
    }
}