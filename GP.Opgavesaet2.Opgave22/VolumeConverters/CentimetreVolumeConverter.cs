using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace GP.Opgavesaet2.Opgave22.VolumeConverters
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

    public class VolumeConverter
    {
        private readonly UniversalRatio[] _universalRatios;

        public VolumeConverter()
        {
            _universalRatios = new UniversalRatio[]
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
        public IEnumerable<string> Suffixes { get { return _universalRatios.Select(ur => ur.Suffix); } }

        public decimal Convert(decimal value, string fromSuffix, string toSuffix)
        {
            var fromRatio = _universalRatios.First(ur => ur.Suffix == fromSuffix).Ratio;
            var toRatio = _universalRatios.First(ur => ur.Suffix == toSuffix).Ratio;
            var universalValue = value*fromRatio;
            return universalValue/toRatio;
        }
    }
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