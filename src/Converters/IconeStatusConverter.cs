using System;
using Windows.UI.Xaml.Data;

namespace Sunshine.UWP.Converters
{
    public class IconeStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return null;
            if (value.ToString().ToLowerInvariant().Equals("céu claro"))
                return $"/Assets/icones/{parameter}clear.png";
            if (value.ToString().ToLowerInvariant().Equals("chuva moderada"))
                return $"/Assets/icones/{parameter}rain.png";
            if (value.ToString().ToLowerInvariant().Equals("neve"))
                return $"/Assets/icones/{parameter}snow.png";
            if (value.ToString().Equals("nuvem"))
                return $"/Assets/icones/{parameter}cloudy.png";
            if (value.ToString().Equals("nuvem_sol"))
                return $"/Assets/icones/{parameter}light_clouds.png";
            if (value.ToString().ToLowerInvariant().Equals("chuva fraca"))
                return $"/Assets/icones/{parameter}light_rain.png";
            if (value.ToString().Equals("nevoa"))
                return $"/Assets/icones/{parameter}fog.png";
            if (value.ToString().ToLowerInvariant().Equals("chuva de intensidade pesado") ||
                value.ToString().ToLowerInvariant().Equals("chuva de intensidade"))
                return $"/Assets/icones/{parameter}storm.png";

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}