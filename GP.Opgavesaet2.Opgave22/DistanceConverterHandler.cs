using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GP.Opgavesaet2.Opgave22
{
    public class DistanceConverterHandler
    {
        private List<DistanceConverterAndInfo> _distanceConvertersAndInfo = new List<DistanceConverterAndInfo>();

        private IEnumerable<DistanceConverterAndInfo> GetDistanceConverters()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => type.GetInterface(nameof(IDistanceConverter)) != null)
                .Where(type => type.GetCustomAttributes<DistanceConverterInformationAttribute>() != null)
                .Select(type => new DistanceConverterAndInfo
                {
                    DistanceConverter = (IDistanceConverter) Activator.CreateInstance(type),
                    DistanceConverterInformationAttribute = type.GetCustomAttribute<DistanceConverterInformationAttribute>()
                });
        }

        public void UpdateDistanceConverters()
        {
            _distanceConvertersAndInfo = new List<DistanceConverterAndInfo>(GetDistanceConverters());
        }

        public IEnumerable<string> GetListOfConverterSuffixes()
        {
            return _distanceConvertersAndInfo
                .Select(dcai => dcai.DistanceConverterInformationAttribute.Suffix);
        }

        public IDistanceConverter GetDistanceConverter(string suffix)
        {
            return _distanceConvertersAndInfo
                .First(dcai => dcai.DistanceConverterInformationAttribute.Suffix == suffix)
                .DistanceConverter;
        }
    }
}
