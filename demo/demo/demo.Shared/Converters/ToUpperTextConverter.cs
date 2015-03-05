using System;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class ToUpperTextConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value == null ? string.Empty : value.ToString().ToUpperInvariant();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}