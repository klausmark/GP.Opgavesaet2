namespace GP.Opgavesaet2.ViewModel
{

    public class Opgave25ViewModel : NotifyBase
    {
        public Opgave25ViewModel()
        {
            CalculateCommand = new DelegateCommand(Calculate, () => Amount != null && ExchangeRate != null);
            EraseCommand = new DelegateCommand(Erase, () => Amount != null || ExchangeRate != null);
        }

        private void Calculate()
        {
            Result = Amount.Value/(ExchangeRate.Value/100f);
        }

        private void Erase()
        {
            Amount = null;
            ExchangeRate = null;
            Result = null;
        }

        public int? Amount
        {
            get { return GetField<int?>(); }
            set
            {
                SetField(value);
                CalculateCommand.RaiseCanExecuteChanged();
                EraseCommand.RaiseCanExecuteChanged();
            }
        }

        public int? ExchangeRate
        {
            get { return GetField<int?>(); }
            set
            {
                SetField(value);
                CalculateCommand.RaiseCanExecuteChanged();
                EraseCommand.RaiseCanExecuteChanged();
            }
        }

        public float? Result
        {
            get { return GetField<float?>(); }
            set { SetField(value); }
        }

        public DelegateCommand CalculateCommand { get; set; }
        public DelegateCommand EraseCommand { get; set; }
    }
}