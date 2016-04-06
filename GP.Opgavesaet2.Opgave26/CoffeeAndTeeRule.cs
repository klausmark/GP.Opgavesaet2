using System.Collections.Generic;

namespace GP.Opgavesaet2.Opgave26
{
    public class CoffeeAndTeeRule : IDrinkRule
    {
        public IEnumerable<ICondiment> AllowedCondiments => new ICondiment[]{ new Sugar(), new Cream() };
    }
}