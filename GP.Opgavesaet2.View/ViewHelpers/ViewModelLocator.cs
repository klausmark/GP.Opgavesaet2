using GP.Opgavesaet2.ViewModel;

namespace GP.Opgavesaet2.View.ViewHelpers
{
    public class ViewModelLocator
    {
        private Opgave21ViewModel _opgave21ViewModel;
        public Opgave21ViewModel Opgave21ViewModel => _opgave21ViewModel ?? (_opgave21ViewModel = new Opgave21ViewModel());

        private Opgave22ViewModel _opgave22ViewModel;
        public Opgave22ViewModel Opgave22ViewModel => _opgave22ViewModel ?? (_opgave22ViewModel = new Opgave22ViewModel());

        private Opgave23ViewModel _opgave23ViewModel;
        public Opgave23ViewModel Opgave23ViewModel => _opgave23ViewModel ?? (_opgave23ViewModel = new Opgave23ViewModel());

        private Opgave24ViewModel _opgave24ViewModel;
        public Opgave24ViewModel Opgave24ViewModel => _opgave24ViewModel ?? (_opgave24ViewModel = new Opgave24ViewModel());

        private Opgave25ViewModel _opgave25ViewModel;
        public Opgave25ViewModel Opgave25ViewModel => _opgave25ViewModel ?? (_opgave25ViewModel = new Opgave25ViewModel());

        private Opgave26ViewModel _opgave26ViewModel;
        public Opgave26ViewModel Opgave26ViewModel => _opgave26ViewModel ?? (_opgave26ViewModel = new Opgave26ViewModel());
    }
}
