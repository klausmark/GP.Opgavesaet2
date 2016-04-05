using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GP.Opgavesaet2.Opgave22
{
    public class ConverterController<T>
    {
        private List<ConverterAndInfo<T>> _convertersAndInfo = new List<ConverterAndInfo<T>>();

        private IEnumerable<ConverterAndInfo<T>> GetConverters()
        {
            var convertersAndInfo = new List<ConverterAndInfo<T>>();
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                convertersAndInfo.AddRange(assembly
                    .GetTypes()
                    .Where(type => type.GetInterface(typeof(T).Name) != null)
                    .Where(type => type.GetCustomAttributes<ConverterInformationAttribute>() != null)
                    .Select(type => new ConverterAndInfo<T>
                    {
                        Converter = (T)Activator.CreateInstance(type),
                        ConverterInformationAttribute = type.GetCustomAttribute<ConverterInformationAttribute>()
                    }));
            }
            return convertersAndInfo;
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
