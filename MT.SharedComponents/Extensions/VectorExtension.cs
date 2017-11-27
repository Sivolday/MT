//using MathNet.Spatial.Euclidean;

//namespace MT.SharedComponents.Extensions
//{
//    public static class VectorExtension
//    {
//        public static System.Windows.Media.Media3D.Vector3D ToVector3D(this Vector3D p)
//        {
//            return new System.Windows.Media.Media3D.Vector3D(p.X, p.Y, p.Z);
//        }

//        /// <summary> Спроецировать на вектор </summary>
//        /// <param name="projectOnVector"> Вектор на который осуществятся проецирование </param>
//        /// <returns> Длина проекции </returns>
//        public static double ProjectOnVector(this Vector3D self, Vector3D projectOnVector)
//        {
//            return self * projectOnVector / projectOnVector.Length;
//        }

//        /// <summary> Проекция вектора в другой системе координат </summary>
//        /// <param name="coordinateSystem"> Система координат в которую осуществляется проецирование </param>
//        /// <returns> Проецированный вектор </returns>
//        public static Vector3D ProjectIntoCoordinateSystem(this Vector3D self, CoordinateSystem coordinateSystem)
//        {
//            return new Vector3D
//            (
//                self.ProjectOnVector(coordinateSystem.XAxis),
//                self.ProjectOnVector(coordinateSystem.YAxis),
//                self.ProjectOnVector(coordinateSystem.ZAxis)
//            );
//        }
//        public static string ToString(this Vector3D self)
//        {
//            return "Пидары";
//        }
//    }
//}
