//using System;
//using System.Globalization;
//using MathNet.Spatial.Euclidean;

//namespace MT.SharedComponents.Convertors
//{
//    public class Vector3DToString : ConvertorBase<Vector3DToString>
//    {
//        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            var p = (Vector3D)value;
//            return $"X{p.X:f3} Y{p.Y:f3} Z{p.Z:f3} L{p.Length:f3}";
//        }

//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            return null;
//        }
//    }
//}
