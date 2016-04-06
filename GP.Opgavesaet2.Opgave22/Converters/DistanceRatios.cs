namespace GP.Opgavesaet2.Opgave22.Converters
{
    [RatiosInfo("Afstand")]
    public class DistanceRatios : IRatios
    {
        public UniversalRatio[] GetRatios()
        {
            return new[] {
                new UniversalRatio("Centimeter", "cm", 1m),
                new UniversalRatio("inch", "in", 2.54m),
                new UniversalRatio("Foot", "ft", 30.48m),
                new UniversalRatio("Yard", "yd", 91.44m),
                new UniversalRatio("Mile", "mile", 160934.4m),
                new UniversalRatio("Sømil", "nm", 185202.576m),
            };
        }
    }
}