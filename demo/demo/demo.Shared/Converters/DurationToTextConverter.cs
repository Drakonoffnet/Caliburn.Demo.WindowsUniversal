using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class DurationToTextConvertor : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var valueInt = int.Parse(value.ToString());

            if (valueInt == 0)
            {
                return string.Empty;
            }

            TimeSpan ts = TimeSpan.FromSeconds(valueInt);
      
            return string.Format("{0} ч. {1} мин.", ts.Hours,ts.Minutes);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
