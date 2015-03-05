using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class YearToTextConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value != null ? string.Format("{0}, ", value) : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
