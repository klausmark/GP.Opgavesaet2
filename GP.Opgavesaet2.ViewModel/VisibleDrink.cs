using GP.Opgavesaet2.Opgave26;

namespace GP.Opgavesaet2.ViewModel
{
    public class VisibleDrink
    {
        public VisibleDrink(IDrink drink)
        {
            Drink = drink;
        }
        public IDrink Drink { get; }
        public string Name => Drink.Name;
    }
}