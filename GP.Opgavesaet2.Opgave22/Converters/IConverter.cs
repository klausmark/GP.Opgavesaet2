using System.Collections.Generic;

namespace GP.Opgavesaet2.Opgave22.Converters
{
    public interface IConverter
    {
        IEnumerable<string> Suffixes { get; }
        string Name { get; }
        decimal Convert(decimal value, string fromSuffix, string toSuffix);
    }
}