using System.Collections.Generic;
using GP.Opgavesaet2.Opgave22.Converters;

namespace GP.Opgavesaet2.ViewModel
{
    public class RatiosViewModel : NotifyBase
    {
        private readonly IConverter _converter;
        private string _fromSuffix;
        private decimal _fromValue;
        private string _toSuffix;

        public RatiosViewModel(IConverter converter)
        {
            _converter = converter;
            _fromValue = 1;
            Suffixes = new List<string>(_converter.Suffixes);
            Name = _converter.Name;
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

        public string Name
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        private void Calculate()
        {
            if (FromSuffix == null || ToSuffix == null) return;

            Result = _converter.Convert(FromValue, FromSuffix, ToSuffix);
        }
    }
}