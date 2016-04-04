using System.Collections.Generic;
using System.Linq;
using GP.Opgavesaet2.Opgave22;
using GP.Opgavesaet2.Opgave22.AreaConverters;
using GP.Opgavesaet2.Opgave22.DistanceConverters;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave22ViewModel : NotifyBase
    {
        private readonly ConverterController<IDistanceConverter> _distanceConverterController;
        private readonly ConverterController<IAreaConverter> _areaConverterController;
        private string _fromDistanceSuffix;
        private decimal _fromDistanceValue;
        private string _toDistanceSuffix;
        private string _fromAreaSuffix;
        private decimal _fromAreaValue;
        private string _toAreaSuffix;

        public Opgave22ViewModel()
        {
            _distanceConverterController = new ConverterController<IDistanceConverter>();
            _distanceConverterController.UpdateConverters();

            DistanceSuffixes = new List<string>(_distanceConverterController.GetListOfConverterSuffixes().OrderBy(s => s));
            FromDistanceSuffix = DistanceSuffixes.First();
            ToDistanceSuffix = FromDistanceSuffix;

            _areaConverterController = new ConverterController<IAreaConverter>();
            _areaConverterController.UpdateConverters();

            AreaSuffixes = new List<string>(_areaConverterController.GetListOfConverterSuffixes());
            FromAreaSuffix = AreaSuffixes.First();
            ToAreaSuffix = FromAreaSuffix;
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

            var universalValue = _distanceConverterController.GetConverter(FromDistanceSuffix).ConvertToUniversalDistance(FromDistanceValue);
            DistanceResult = _distanceConverterController.GetConverter(ToDistanceSuffix).ConvertFromUniversalDistance(universalValue);
        }

        public List<string> AreaSuffixes { get; }

        public decimal FromAreaValue
        {
            get { return _fromAreaValue; }
            set
            {
                _fromAreaValue = value;
                CalculateArea();
            }
        }

        public string FromAreaSuffix
        {
            get { return _fromAreaSuffix; }
            set
            {
                _fromAreaSuffix = value;
                CalculateArea();
            }
        }

        public string ToAreaSuffix
        {
            get { return _toAreaSuffix; }
            set
            {
                _toAreaSuffix = value;
                CalculateArea();
            }
        }

        public decimal AreaResult
        {
            get { return GetField<decimal>(); }
            set { SetField(value); }
        }

        private void CalculateArea()
        {
            if (FromAreaSuffix == null || ToAreaSuffix == null) return;

            var universalValue = _areaConverterController.GetConverter(FromAreaSuffix).ConvertToUniversalArea(_fromAreaValue);
            DistanceResult = _areaConverterController.GetConverter(ToAreaSuffix).ConvertFromUniversalArea(universalValue);
        }
    }
}