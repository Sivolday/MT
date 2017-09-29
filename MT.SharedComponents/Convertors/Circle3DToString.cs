using System;
using System.Globalization;
using MathNet.Spatial.Euclidean;

namespace MT.SharedComponents.Convertors
{
    public class Circle3DToString : ConvertorBase<Circle3DToString>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var p = (Circle3D)value;
            return $"R:{p.Radius:f3}";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
