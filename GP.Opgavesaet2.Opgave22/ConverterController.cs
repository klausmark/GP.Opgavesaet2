using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GP.Opgavesaet2.Opgave22.DistanceConverters;

namespace GP.Opgavesaet2.Opgave22
{
    public class ConverterController<T>
    {
        private List<ConverterAndInfo<T>> _convertersAndInfo = new List<ConverterAndInfo<T>>();

        private IEnumerable<ConverterAndInfo<T>> GetConverters()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => type.GetInterface(typeof (T).Name) != null)
                .Where(type => type.GetCustomAttributes<ConverterInformationAttribute>() != null)
                .Select(type => new ConverterAndInfo<T>
                {
                    Converter = (T) Activator.CreateInstance(type),
                    ConverterInformationAttribute = type.GetCustomAttribute<ConverterInformationAttribute>()
                });
        }

        public void UpdateConverters()
        {
            _convertersAndInfo = new List<ConverterAndInfo<T>>(GetConverters());
        }

        public IEnumerable<string> GetListOfConverterSuffixes()
        {
            return _convertersAndInfo
                .Select(dcai => dcai.ConverterInformationAttribute.Suffix);
        }

        public T GetConverter(string suffix)
        {
            return _convertersAndInfo
                .First(dcai => dcai.ConverterInformationAttribute.Suffix == suffix)
                .Converter;
        }
    }
}
