using System;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class ToLowerTextConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value == null ? string.Empty : value.ToString().ToLowerInvariant();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}