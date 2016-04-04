using System;

namespace GP.Opgavesaet2.Opgave22.AreaConverters
{
    public interface IAreaConverter
    {
        decimal ConvertFromUniversalArea(decimal universalArea);
        decimal ConvertToUniversalArea(decimal area);
    }
}
