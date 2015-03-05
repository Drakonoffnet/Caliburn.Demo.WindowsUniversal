using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class EmptyNullTextToVisibilityConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return value == null || string.IsNullOrWhiteSpace(value.ToString())
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}