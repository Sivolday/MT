using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace MT.SharedComponents.Convertors
{
    /// <summary>
    /// Кновертер для XAML
    /// https://habrahabr.ru/post/140876/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ConvertorBase<T> : MarkupExtension, IValueConverter 
        where T : class, new()
    {
        /// <summary>
        /// Must be implemented in inheritor.
        /// https://habrahabr.ru/post/140876/
        /// </summary>
        public abstract object Convert(object value, Type targetType, object parameter,
            CultureInfo culture);

        /// <summary>
        /// Override if needed.
        /// </summary>
        public virtual object ConvertBack(object value, Type targetType, object parameter,
            CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #region MarkupExtension members

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (_converter == null)
                _converter = new T();
            return _converter;
        }

        private static T _converter = null;

        #endregion
    }
}
