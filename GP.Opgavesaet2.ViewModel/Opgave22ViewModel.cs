using System.Collections.Generic;
using GP.Opgavesaet2.Opgave22;
using GP.Opgavesaet2.Opgave22.AreaConverters;
using GP.Opgavesaet2.Opgave22.DistanceConverters;
using GP.Opgavesaet2.Opgave22.VolumeConverters;
using GP.Opgavesaet2.Opgave22.WeightConverters;

namespace GP.Opgavesaet2.ViewModel
{
    public class Opgave22ViewModel : NotifyBase
    {
        public ConverterViewModel<IAreaConverter> AreaConverterViewModel { get; }
        public ConverterViewModel<IDistanceConverter> DistanceConverterViewModel { get; }
        public VolumeConverterViewModel VolumeConverterViewModel { get; }
        public ConverterViewModel<IWeightConverter> WeightConverterViewModel { get; }

        public Opgave22ViewModel()
        {
            AreaConverterViewModel = 
                new ConverterViewModel<IAreaConverter>(
                    new ConverterController<IAreaConverter>());
            DistanceConverterViewModel =
                new ConverterViewModel<IDistanceConverter>(
                    new ConverterController<IDistanceConverter>());
            VolumeConverterViewModel = new VolumeConverterViewModel();
            WeightConverterViewModel =
                new ConverterViewModel<IWeightConverter>(
                    new ConverterController<IWeightConverter>());
        }
    }

    public class VolumeConverterViewModel : NotifyBase
    {
        private VolumeConverter _volumeConverter = new VolumeConverter();
        private decimal _fromValue;
        private string _fromSuffix;
        private string _toSuffix;
        public IEnumerable<string> Suffixes => _volumeConverter.Suffixes;

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

            Result = _volumeConverter.Convert(FromValue, FromSuffix, ToSuffix);
        }
    }
}