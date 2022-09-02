using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace DietApp.Views.Converters
{
    public class DayIndexConverter : MarkupExtension, IValueConverter
    {
        private static DayIndexConverter converter = null;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (converter == null) converter = new DayIndexConverter();
            return converter;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DayOfWeek)
            {
                return (int)value;
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value < 0 || (int)value > 6)
            {
                return false;
            }
            else
            {
                return (DayOfWeek)value;
            }
        }
    }
}
