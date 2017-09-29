using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MT.SharedComponents
{
    public class WolframHelper
    {
        public List<double[]> ListData { get; set; } = new List<double[]>();

        public void ExportList(List<double[]> listData = null, string filePath = "")
        {
            if (filePath == string.Empty)
                filePath = FileHelper.GetPathToMyProject("ListLinePlot.m");

            if (listData != null)
                ListData = listData;

            var sb = new StringBuilder();
            sb.AppendLine("{");

            ListData.ForEach(row =>
                sb.AppendLine("\t{" + $"{row[0]}, {row[1]}" + "},")
            );

            sb.Remove(sb.Length - 3, 1);    // Снос последней запятой
            sb.Replace("E", "*^");          // Замена экспоненты

            sb.AppendLine("}\n");

            using (var sw = new StreamWriter(filePath.Replace("RollGlider.View", "!RollGlider.Research"), false, Encoding.Default))
            {
                sw.Write(sb);
            }

            Debug.WriteLine($"График выгружен сюда: {filePath}");
        }
        
    }
}
