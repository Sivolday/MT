using System;
using System.Globalization;
using MathNet.Spatial.Euclidean;

namespace MT.SharedComponents.Convertors
{
    public class Point3DToString : ConvertorBase<Point3DToString>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var p = (Point3D)value;
            return $"X{p.X:f3} Y{p.Y:f3} Z{p.Z:f3}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
