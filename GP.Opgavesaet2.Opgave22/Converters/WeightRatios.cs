namespace GP.Opgavesaet2.Opgave22.Converters
{
    [RatiosInfo("Vægt")]
    public class WeightRatios : IRatios
    {
        public UniversalRatio[] GetRatios()
        {
            return new[]
            {
                new UniversalRatio("gram", "g", 1m),
                new UniversalRatio("Ounce", "oz", 28.35m),
                new UniversalRatio("Pound", "lb", 453.6m),
                new UniversalRatio("Stone", "stone", 6350.4m),
                new UniversalRatio("Hundredweight", "cwt", 711244.8m),
                new UniversalRatio("Ton", "ton", 14224896m),
            };
        }
    }
}