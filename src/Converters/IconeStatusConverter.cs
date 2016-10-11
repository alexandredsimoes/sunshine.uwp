﻿using System;
using Windows.UI.Xaml.Data;

namespace Sunshine.UWP.Converters
{
    public class IconeStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null) return null;
            if (value.ToString().Equals("sol"))
                return $"/Assets/icones/{parameter}clear.png";
            if (value.ToString().Equals("chuva"))
                return $"/Assets/icones/{parameter}rain.png";
            if (value.ToString().Equals("neve"))
                return $"/Assets/icones/{parameter}snow.png";
            if (value.ToString().Equals("nuvem"))
                return $"/Assets/icones/{parameter}cloudy.png";
            if (value.ToString().Equals("nuvem_sol"))
                return $"/Assets/icones/{parameter}light_clouds.png";
            if (value.ToString().Equals("chuva_leve"))
                return $"/Assets/icones/{parameter}light_rain.png";
            if (value.ToString().Equals("nevoa"))
                return $"/Assets/icones/{parameter}fog.png";
            if (value.ToString().Equals("tempestade"))
                return $"/Assets/icones/{parameter}storm.png";

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}