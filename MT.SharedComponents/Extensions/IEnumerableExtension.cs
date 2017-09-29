using System;
using System.Collections.Generic;
using System.Linq;

namespace MT.SharedComponents.Extensions
{
    /// <summary> Расширения для IEnumerable </summary>
    public static class IEnumerableExtension
    {
        /// <summary>
        /// Проверка на наличие элементов в IEnumerable
        /// </summary>
        /// <typeparam name="T">Тип полеекции</typeparam>
        /// <param name="source"> Коллекция </param>
        /// <returns> Пустая или не очень коллекция  </returns>
        public static Boolean IsEmpty<T>(this IEnumerable<T> source)
        {
            if (source == null)
                return true; // or throw an exception
            return !source.Any();
        }
    }
}
