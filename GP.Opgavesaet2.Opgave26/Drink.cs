using System.Collections.Generic;
using System.Linq;

namespace GP.Opgavesaet2.Opgave26
{
    public class Drink : IDrink
    {
        private readonly IDrinkRule _drinkRule;

        public Drink(string name, float price, IDrinkRule drinkRule)
        {
            Name = name;
            Price = price;
            _drinkRule = drinkRule;
        }

        public string Name { get; }
        public float Price { get; }
        public IEnumerable<ICondiment> AllowedCondiments => _drinkRule.AllowedCondiments;
        public float CalculatePriceWithCondiments(IEnumerable<ICondiment> condiments)
        {
            return Price + condiments.Sum(c => c.Price);
        }
    }
}