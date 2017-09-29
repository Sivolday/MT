using System;
using System.Windows.Media;

namespace MT.SharedComponents
{
    public static class ColorHelper
    {
        /// <summary>
        /// Градиент от синего к красному
        /// </summary>
        /// <returns>Цвет</returns>
        public static Color HeatMap(double value, double min, double max)
        {
            var val = (value - min) / (max - min);

            // Если вдруг поделили на ноль
            if (double.IsNaN(val))
                val = 0.0;

            return new Color
            {
                A = 255,
                R = Convert.ToByte(255 * val),
                G = 0,
                B = Convert.ToByte(255 * (1 - val))
            };
        }
    }
}
