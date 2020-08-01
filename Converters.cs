using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ContrastModifier
{
    class Converters
    {
    }

    public class BackgroundConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var ret = Brushes.Black;

            if (values.Count() == 2)
            {
                bool mainWhite = (bool)values[0];

                if (values[1] is bool b && b || mainWhite)
                        return Brushes.White;
            }

            return ret;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }


    public class ForegroundConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var ret = Brushes.White;

            if (values.Count() == 2)
            {
                bool mainWhite = (bool)values[0];

                if (values[1] is bool b && b || mainWhite)
                    return Brushes.Black;
            }

            return ret;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
