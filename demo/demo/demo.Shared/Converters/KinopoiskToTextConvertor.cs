using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class KinopoiskToTextConvertor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {

            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return string.Empty;
            }

          

            return string.Format("{0} КиноПоиск", Math.Round(decimal.Parse(value.ToString()),1));  
          
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}