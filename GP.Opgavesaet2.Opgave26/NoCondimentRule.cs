using System.Collections.Generic;
using System.Linq;

namespace GP.Opgavesaet2.Opgave26
{
    public class NoCondimentRule : IDrinkRule
    {
        public IEnumerable<ICondiment> AllowedCondiments => Enumerable.Empty<ICondiment>();
    }
}