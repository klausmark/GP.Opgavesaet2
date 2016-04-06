using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GP.Opgavesaet2.Opgave22.Converters
{
    public class RatioFinder
    {
        public IEnumerable<RatiosAndInfo> GetRatios()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => type.GetInterface(nameof(IRatios)) != null)
                .Where(type => type.GetCustomAttribute<RatiosInfoAttribute>() != null)
                .Select(type => new RatiosAndInfo(
                    (IRatios) Activator.CreateInstance(type), 
                    type.GetCustomAttribute<RatiosInfoAttribute>()));
        }
    }
}