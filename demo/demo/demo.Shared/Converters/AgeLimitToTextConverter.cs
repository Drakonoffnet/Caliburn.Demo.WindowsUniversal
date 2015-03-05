using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class AgeLimitToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value != null ? string.Format("{0}+", value) : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}