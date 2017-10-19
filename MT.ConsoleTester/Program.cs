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
            CheckGetSelectedPointsCoordinates();

            Console.ReadKey();
        }

        private static void CheckGetSelectedPointsCoordinates()
        {
            var points = Points.GetSelectedPointsCoordinates();
            points.ForEach(pt => Console.WriteLine($"{pt[0]}\t{pt[1]}\t {pt[2]}"));
        }
    }
}
