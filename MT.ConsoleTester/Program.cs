using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.AutoCAD;

namespace MT.ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // CheckGetSelectedPointsCoordinates();
            CheckAddPoints();

            Console.ReadKey();
        }

        private static void CheckGetSelectedPointsCoordinates()
        {
            var points = Points.GetSelectedPointsCoordinates();
            points.ForEach(pt => Console.WriteLine($"{pt[0]}\t{pt[1]}\t {pt[2]}"));
        }

        private static void CheckAddPoints()
        {
            var points = new List<double[]>();

            for (double i = 0; i < 10; i++)
            {
                points.Add(new[] { i, i, 0 });
            }

            Points.AddPoints(points);
        }
    }
}
