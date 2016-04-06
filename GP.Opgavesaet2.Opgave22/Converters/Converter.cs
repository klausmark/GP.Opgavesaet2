using System.Collections.Generic;
using System.Linq;

namespace GP.Opgavesaet2.Opgave22.Converters
{
    public class Converter : IConverter
    {
        private readonly UniversalRatio[] _universalRatios;

        public Converter(IRatios ratios, string name)
        {
            _universalRatios = ratios.GetRatios();
            Name = name;
        }

        public IEnumerable<string> Suffixes { get { return _universalRatios.Select(ur => ur.Suffix); } }
        public string Name { get; }

        public decimal Convert(decimal value, string fromSuffix, string toSuffix)
        {
            var fromRatio = _universalRatios.First(ur => ur.Suffix == fromSuffix).Ratio;
            var toRatio = _universalRatios.First(ur => ur.Suffix == toSuffix).Ratio;
            var universalValue = value * fromRatio;
            return universalValue / toRatio;
        }
    }
}