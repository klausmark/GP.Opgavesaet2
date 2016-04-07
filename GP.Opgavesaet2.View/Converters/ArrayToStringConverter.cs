using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace GP.Opgavesaet2.View.Converters
{
    public class ArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            var array = ((IEnumerable)value).Cast<object>().ToArray();
            var result = $"{value.GetType().Name} {{ ";
            for (var i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();
                if (i < array.Length - 1) result += ", ";
            }
            return result + " }";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
