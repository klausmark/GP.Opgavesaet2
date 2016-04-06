namespace GP.Opgavesaet2.Opgave22.Converters
{
    [RatiosInfo("Areal")]
    public class AreaRatios : IRatios
    {
        public UniversalRatio[] GetRatios()
        {
            return new[]
            {
                new UniversalRatio("Kvadratcentimeter", "cm\u00b2", 1m),
                new UniversalRatio("Square inch", "in\u00b2", 6.4516m),
                new UniversalRatio("Square foot", "ft\u00b2", 929.0304m),
                new UniversalRatio("Square yard", "yd\u00b2", 8361.2736m),
                new UniversalRatio("Acre", "acre", 40468564.224m),
                new UniversalRatio("Square mile", "mile\u00b2", 25899881103.36m),
            };
        }
    }
}