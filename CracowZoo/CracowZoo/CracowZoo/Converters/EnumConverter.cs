using CracowZoo.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using static CracowZoo.Helpers.EnumHelper;

namespace CracowZoo.Converters
{
    public class EnumConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is AnimalDanger)
            {
                return ((AnimalDanger)value).GetDescription();
            }
            else if (value is AnimalGroup)
            {
                return ((AnimalGroup)value).GetDescription();
            }
            else if (value is ConservationStatus)
            {
                return ((ConservationStatus)value).GetDescription();
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
