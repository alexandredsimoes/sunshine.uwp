using System;
using Windows.UI.Xaml.Data;

namespace Sunshine.UWP.Converters
{
    public class DataExtensoConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return null;
            var data = DateTime.Parse(value.ToString());

            if (Math.Round(Math.Abs(data.Subtract(DateTime.Now).TotalDays)) == 1)
            {
                return "Amanhã";
            }
            return data.ToString("dddd");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}