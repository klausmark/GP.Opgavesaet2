using GP.Opgavesaet2.Opgave26;

namespace GP.Opgavesaet2.ViewModel
{
    public class SelectableCondiment
    {
        public SelectableCondiment(ICondiment condiment)
        {
            Condiment = condiment;
        }

        public readonly ICondiment Condiment;
        public string Name => Condiment.Name;

        public bool Selected { get; set; }
    }
}