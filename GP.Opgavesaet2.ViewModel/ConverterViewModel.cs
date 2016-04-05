using System.Collections.Generic;
using GP.Opgavesaet2.Opgave22;

namespace GP.Opgavesaet2.ViewModel
{
    public class ConverterViewModel<T> : NotifyBase where T : IConverter
    {
        private readonly ConverterController<T> _converterController;
        private string _fromSuffix;
        private decimal _fromValue;
        private string _toSuffix;

        public ConverterViewModel(ConverterController<T> converterController)
        {
            _fromValue = 1;
            _converterController = converterController;
            _converterController.UpdateConverters();
            Suffixes = new List<string>(_converterController.GetListOfConverterSuffixes());
            if (Suffixes.Count > 0)
            {
                FromSuffix = Suffixes[0];
                ToSuffix = Suffixes.Count > 1 ? Suffixes[1] : FromSuffix;
            }
        }

        public List<string> Suffixes { get; }

        public decimal FromValue
        {
            get { return _fromValue; }
            set
            {
                _fromValue = value;
                Calculate();
            }
        }

        public string FromSuffix
        {
            get { return _fromSuffix; }
            set
            {
                _fromSuffix = value;
                Calculate();
            }
        }

        public string ToSuffix
        {
            get { return _toSuffix; }
            set
            {
                _toSuffix = value;
                Calculate();
            }
        }

        public decimal Result
        {
            get { return GetField<decimal>(); }
            set { SetField(value); }
        }

        private void Calculate()
        {
            if (FromSuffix == null || ToSuffix == null) return;

            var universalValue = _converterController.GetConverter(FromSuffix).ConvertToUniversalValue(FromValue);
            Result = _converterController.GetConverter(ToSuffix).ConvertFromUniversalValue(universalValue);
        }
    }
}