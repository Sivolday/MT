using System;

namespace MT.SharedComponents
{
    public static class MathHelper
    {
        /// <summary>
        /// Знак числа
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double Sign(double number)
        {
            return number >= 0.0 ? +1 : -1;
        }
        /// <summary> Расстояние между двумя точками, через координаты </summary>
        public static double EuclideanDistance(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        /// <summary> Расстояние между двумя точками, через разность координат </summary>
        public static double EuclideanDistance(double dx, double dy) =>
            Math.Sqrt(dx * dx + dy * dy);

        /// <summary>
        /// арктангенс гиперболический
        /// </summary>
        public static double ATanH(double x) =>
             (Math.Log(1 + x) - Math.Log(1 - x)) / 2;
    }
}
