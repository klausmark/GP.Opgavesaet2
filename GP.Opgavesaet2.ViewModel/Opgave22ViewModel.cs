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
        public ConverterViewModel<IVolumeConverter> VolumeConverterViewModel { get; }
        public ConverterViewModel<IWeightConverter> WeightConverterViewModel { get; }

        public Opgave22ViewModel()
        {
            AreaConverterViewModel = 
                new ConverterViewModel<IAreaConverter>(
                    new ConverterController<IAreaConverter>());
            DistanceConverterViewModel =
                new ConverterViewModel<IDistanceConverter>(
                    new ConverterController<IDistanceConverter>());
            VolumeConverterViewModel =
                new ConverterViewModel<IVolumeConverter>(
                    new ConverterController<IVolumeConverter>());
            WeightConverterViewModel =
                new ConverterViewModel<IWeightConverter>(
                    new ConverterController<IWeightConverter>());
        }
    }
}