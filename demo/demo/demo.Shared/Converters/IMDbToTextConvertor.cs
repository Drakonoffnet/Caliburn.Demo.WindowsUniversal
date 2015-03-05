using System;
using System.Diagnostics;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public class ImdbToTextConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    return string.Empty;
                }

                //6.50 (20)"

                var spl = value.ToString().Split(' ');

                var ratingStr = spl[0];

                double rating = 0;

                if (double.TryParse(ratingStr, out rating))
                {
                    return string.Format("{0} IMDb", Math.Round(rating, 1));
                }
            }
            catch (Exception err)
            {

                Debug.WriteLine(err.Message);
               
            }

            return string.Empty;
        }


        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}