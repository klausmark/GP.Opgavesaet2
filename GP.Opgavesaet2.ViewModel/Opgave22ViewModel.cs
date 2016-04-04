using System.Collections.Generic;
using System.Linq;
using GP.Opgavesaet2.Opgave22;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave22ViewModel : NotifyBase
    {
        private readonly DistanceConverterHandler _distanceConverterHandler;
        private string _fromDistanceSuffix;
        private decimal _fromDistanceValue;
        private string _toDistanceSuffix;

        public Opgave22ViewModel()
        {
            _distanceConverterHandler = new DistanceConverterHandler();
            _distanceConverterHandler.UpdateDistanceConverters();

            DistanceSuffixes = new List<string>(_distanceConverterHandler.GetListOfConverterSuffixes().OrderBy(s => s));
            FromDistanceSuffix = DistanceSuffixes.First();
            ToDistanceSuffix = FromDistanceSuffix;
        }

        public List<string> DistanceSuffixes { get; }

        public decimal FromDistanceValue
        {
            get { return _fromDistanceValue; }
            set
            {
                _fromDistanceValue = value; 
                CalculateDistance();
            }
        }

        public string FromDistanceSuffix
        {
            get { return _fromDistanceSuffix; }
            set
            {
                _fromDistanceSuffix = value;
                CalculateDistance();
            }
        }

        public string ToDistanceSuffix
        {
            get { return _toDistanceSuffix; }
            set
            {
                _toDistanceSuffix = value; 
                CalculateDistance();
            }
        }

        public decimal DistanceResult
        {
            get { return GetField<decimal>(); }
            set { SetField(value); }
        }

        private void CalculateDistance()
        {
            if (FromDistanceSuffix == null || ToDistanceSuffix == null) return;

            var universalValue = _distanceConverterHandler.GetDistanceConverter(FromDistanceSuffix).ConvertToUniversalDistance(FromDistanceValue);
            DistanceResult = _distanceConverterHandler.GetDistanceConverter(ToDistanceSuffix).ConvertFrom(universalValue);
        }
    }
}