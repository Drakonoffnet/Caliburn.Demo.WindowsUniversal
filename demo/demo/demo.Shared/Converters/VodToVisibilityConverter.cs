using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Megogo.Converters
{
    public abstract class VodToVisibilityConverter : IValueConverter
    {
        private readonly string _rules;

        protected VodToVisibilityConverter(string rules)
        {
            _rules = rules;
        }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var items = value as List<string>;

            return items != null && items.Any() && items.First() == _rules
                ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}