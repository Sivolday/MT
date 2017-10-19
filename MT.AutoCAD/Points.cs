using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Interop.Common;

namespace MT.AutoCAD
{
    public static class Points
    {
        /// <summary> Получение координат точек выбранных в автоГаде </summary>
        /// <returns> Список из 3х коориднат </returns>
        public static List<double[]> GetSelectedPointsCoordinates()
        {
            var pointsCoordinates = new List<double[]>();

            Select.OnScreen(Primitives.Point)
                .ForEach(pt =>
                {
                    pointsCoordinates.Add((double[])((AcadPoint)pt).Coordinates);
                });

            return pointsCoordinates;
        }

        public static void AddPoints(List<double[]> points)
        {
            var acadDocument = DocumentLocator.GetAcadDocument();

            points.ForEach
            (
                pt => acadDocument.Database.ModelSpace.AddPoint(pt)
            );
        }
    }
}
