using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace MT.SharedComponents.Extensions
{
    public static class ListExtension
    {
        /// <summary> Засылает в буфер обмена список для математики </summary>
        /// <param name="list"></param>
        public static void ToWolframListInClipboard<T>(this List<T> list)
        {
            var sb = new StringBuilder();
            sb.Append("{");

            list.ForEach(number =>
                sb.Append($"{number},".Replace("E", "*^"))
            );
            sb.Remove(sb.Length - 1, 1);    // Снос последней запятой
            sb.Append("}");

            Clipboard.SetText(sb.ToString());
        }
    }
}
