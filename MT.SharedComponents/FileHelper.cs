using System;
using System.IO;
using System.Reflection;

namespace MT.SharedComponents
{
    public static class FileHelper
    {
        public static string GetPathToMyProject()
        {
            return AppDomain.CurrentDomain.BaseDirectory
                .Replace("bin\\Debug\\", string.Empty)
                .Replace("bin\\Release\\", string.Empty);
        }
        public static string GetPathToMyProject(string plusPath)
        {
            return GetPathToMyProject() + plusPath;
        }

        public static string GetPathToExeDir(string additionalPath = "")
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName + "\\" + additionalPath;
        }
    }
}