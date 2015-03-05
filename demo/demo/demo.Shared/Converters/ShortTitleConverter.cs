using System;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class ShortTitleConverter : IValueConverter
    {

        private int _length = 18;

        public ShortTitleConverter()
        {
        }

        public ShortTitleConverter(int length)
        {
            _length = length;
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return null;
            }

            var value2 = value.ToString();
            int length = value2.Length;

           
            return
                length > _length ?
                string.Format("{0}...", value.ToString().Substring(0, _length)) 
                : value2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}