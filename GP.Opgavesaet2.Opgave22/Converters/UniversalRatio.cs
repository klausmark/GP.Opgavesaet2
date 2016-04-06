namespace GP.Opgavesaet2.Opgave22.Converters
{
    public class UniversalRatio
    {
        public UniversalRatio(string name, string suffix, decimal ratio)
        {
            Name = name;
            Suffix = suffix;
            Ratio = ratio;
        }

        public string Name { get; }
        public string Suffix { get; }
        public decimal Ratio { get; }
    }
}