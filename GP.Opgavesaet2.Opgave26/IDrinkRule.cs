using System.Collections.Generic;

namespace GP.Opgavesaet2.Opgave26
{
    public interface IDrinkRule
    {
        IEnumerable<ICondiment> AllowedCondiments { get; } 
    }
}