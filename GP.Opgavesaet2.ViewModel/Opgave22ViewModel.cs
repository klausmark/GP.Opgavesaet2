using System.Collections.Generic;
using System.Linq;
using GP.Opgavesaet2.Opgave22.Converters;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave22ViewModel : NotifyBase
    {
        public Opgave22ViewModel()
        {
            RatiosViewModels = new RatioFinder()
                .GetRatios()
                .OrderBy(ratiosAndInfo => ratiosAndInfo.RatiosInfoAttribute.Name)
                .Select(ratiosAndInfo => new RatiosViewModel(new Converter(ratiosAndInfo.Ratios, ratiosAndInfo.RatiosInfoAttribute.Name)))
                .ToList();
        }
        public List<RatiosViewModel> RatiosViewModels { get; }
    }
}