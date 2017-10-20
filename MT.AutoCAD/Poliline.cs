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

            acadDocument.Database.ModelSpace.AddPolyline
                (
                points.SelectMany(pt => new[]
                    {
                        pt[0] * DocumentLocator.Scale,
                        pt[1] * DocumentLocator.Scale,
                        pt[2] * DocumentLocator.Scale,
                    }).ToArray()
            );
        }
    }
}