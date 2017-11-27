using System;
using System.Collections.Generic;
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

        /// <summary> Считывания CSV из ресурсов </summary>
        public static List<List<string>> GetRawCSVDataFormFile(string nameFile)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var inputData = new List<List<string>>();

            using (Stream stream = assembly.GetManifestResourceStream(nameFile))

            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    inputData.Add(new List<string>(reader.ReadLine().Split(';')));
                }
            }

            return inputData;
        }
    }
}