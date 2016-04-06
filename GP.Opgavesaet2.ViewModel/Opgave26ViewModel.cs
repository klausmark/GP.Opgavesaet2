using System.Collections.Generic;
using System.Linq;
using GP.Opgavesaet2.Opgave26;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave26ViewModel : NotifyBase
    {
        public Opgave26ViewModel()
        {
            HotDrinks = new DrinkFactory().GetDrinks().Select(drink => new VisibleDrink(drink));
            CalculateCommand = new DelegateCommand(CalculatePrice, () => SelectedDrink != null);
        }

        public float Price
        {
            get { return GetField<float>(); }
            set { SetField(value); }
        }

        public IEnumerable<VisibleDrink> HotDrinks { get; }

        public VisibleDrink SelectedDrink
        {
            get { return GetField<VisibleDrink>(); }
            set
            {
                SetField(value);
                Condiments = new List<SelectableCondiment>(value.Drink.AllowedCondiments.Select(condiment => new SelectableCondiment(condiment)));
                CalculateCommand.RaiseCanExecuteChanged();
            }
        }

        public List<SelectableCondiment> Condiments
        {
            get { return GetField<List<SelectableCondiment>>(); }
            set { SetField(value);}
        }

        public DelegateCommand CalculateCommand { get; }

        private void CalculatePrice()
        {
            var condiments = Condiments.Where(sc => sc.Selected).Select(sc => sc.Condiment);
            Price = SelectedDrink.Drink.CalculatePriceWithCondiments(condiments);
        }
    }
}
