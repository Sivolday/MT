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
    }
}
