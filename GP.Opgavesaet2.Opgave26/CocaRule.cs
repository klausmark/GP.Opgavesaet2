using System.Collections.Generic;

namespace GP.Opgavesaet2.Opgave26
{
    public class CocaRule : IDrinkRule
    {
        public IEnumerable<ICondiment> AllowedCondiments => new ICondiment[] { new WhippedCream() };
    }
}