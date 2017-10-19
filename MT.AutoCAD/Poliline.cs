using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.AutoCAD
{
    public static class PoliLine
    {
        public static void Add(List<double[]> points)
        {
            var acadDocument = DocumentLocator.GetAcadDocument();

            acadDocument.Database.ModelSpace.AddPolyline(points.SelectMany(pt => pt).ToArray());
        }
    }
}