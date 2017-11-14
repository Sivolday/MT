using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace MT.SharedComponents
{
    public class WolframHelper
    {
        public double[][] ListData { get; set; }

        public void ExportList(double[][] listData = null, string filePath = "")
        {
            if (filePath == string.Empty)
                filePath = FileHelper.GetPathToMyProject("ListLinePlot.m");

            if (listData != null)
                ListData = listData;

            var sb = new StringBuilder();


            sb.AppendLine("{\n");
            
            for (int i = 0; i < ListData.Length; i++)
            {
                sb.Append("\t{");
                for (int j = 0; j < ListData[i].Length; j++)
                {
                    sb.Append($" {ListData[i][j]},");
                }
                sb.Remove(sb.Length - 1, 1);    // Снос последней запятой
                sb.AppendLine(" },");
            }

            sb.Remove(sb.Length - 3, 1);    // Снос последней запятой
            sb.Replace("E", "*^");          // Замена экспоненты

            sb.AppendLine("}\n");

            using (var sw = new StreamWriter(filePath, false, Encoding.Default))
            {
                sw.Write(sb);
            }

            Debug.WriteLine($"График выгружен сюда: {filePath}");
        }
        
    }
}
