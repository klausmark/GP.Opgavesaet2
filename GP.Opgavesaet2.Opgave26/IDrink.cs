using System.Collections.Generic;

namespace GP.Opgavesaet2.Opgave26
{
    public interface IDrink
    {
        string Name { get; }
        float Price { get; }
        IEnumerable<ICondiment> AllowedCondiments { get; }
        float CalculatePriceWithCondiments(IEnumerable<ICondiment> condiments);
    }
}