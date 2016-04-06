using System;

namespace GP.Opgavesaet2.Opgave22.Converters
{
    public class RatiosInfoAttribute : Attribute
    {
        public RatiosInfoAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}