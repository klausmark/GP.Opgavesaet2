using System;

namespace GP.Opgavesaet2.Opgave22
{
    public class ConverterInformationAttribute : Attribute
    {
        public ConverterInformationAttribute(string suffix)
        {
            Suffix = suffix;
        }

        public string Suffix { get; }
    }
}