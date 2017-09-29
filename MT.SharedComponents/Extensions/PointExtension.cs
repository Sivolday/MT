using MathNet.Spatial.Euclidean;

namespace MT.SharedComponents.Extensions
{
    public static class PointExtension
    {
        public static System.Windows.Media.Media3D.Point3D ToPoint3D(this MathNet.Spatial.Euclidean.Point3D p)
        {
            return new System.Windows.Media.Media3D.Point3D(p.X, p.Y, p.Z);
        }

        public static System.Windows.Media.Media3D.Vector3D ToVector3D(this MathNet.Spatial.Euclidean.Point3D p)
        {
            return new System.Windows.Media.Media3D.Vector3D(p.X, p.Y, p.Z);
        }

        public static Point3D Minus(this Point3D a, Point3D b)
        {
            return new Point3D(b.X - a.X, b.Y - a.Y, b.Z - a.Z);
        }
        public static Point3D Plus(this Point3D a, Point3D b)
        {
            return new Point3D(b.X + a.X, b.Y + a.Y, b.Z + a.Z);
        }

        /// <summary>
        /// Проверка что три точки лежат на одной прямой
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsOnOneLine(Point3D a, Point3D b, Point3D c)
        {
            return (a - b).IsParallelTo(b - c);
        }
    }
}