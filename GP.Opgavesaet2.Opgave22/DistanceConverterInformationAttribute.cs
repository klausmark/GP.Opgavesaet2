using System;

namespace GP.Opgavesaet2.Opgave22
{
    public class DistanceConverterInformationAttribute : Attribute
    {
        public DistanceConverterInformationAttribute(string suffix)
        {
            Suffix = suffix;
        }

        public string Suffix { get; }
    }
}