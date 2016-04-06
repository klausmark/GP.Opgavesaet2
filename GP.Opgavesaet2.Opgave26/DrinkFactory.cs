using System.Collections.Generic;

namespace GP.Opgavesaet2.Opgave26
{
    public class DrinkFactory
    {
        public IEnumerable<IDrink> GetDrinks()
        {
            return new[]
            {
                new Drink("Kaffe", 6, new CoffeeAndTeeRule()),
                new Drink("The", 5, new CoffeeAndTeeRule()),
                new Drink("Cacao", 7, new CocaRule()),
                new Drink("Suppe", 7, new NoCondimentRule())
            };
        }
    }
}