using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;
using MathNet.Spatial.Euclidean;
using MT.SharedComponents.Extensions;

namespace MT.SharedComponents.Convertors
{
    /// <summary> Конвертер точки да XAML </summary>
    public class PointConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Point3D)value).ToPoint3D();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (_converter == null)
                _converter = new PointConverter();
            return _converter;
        }
        private static PointConverter _converter = null;
    }
}