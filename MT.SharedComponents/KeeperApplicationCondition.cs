using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MT.SharedComponents
{
    /// <summary> Хранитель настоек и состояния приложения </summary>
    public static class KeeperApplicationCondition
    {
        /// <summary> Загрузить файл </summary>
        /// <typeparam name="T"> Кастуемый тип </typeparam>
        /// <param name="pathToFile">Пусть до файл</param>
        /// <returns>Объект</returns>
        public static T LoadFromFile<T>(string pathToFile)
        {
            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(fs);
            }
        }
        /// <summary> Сохранение объекта на диск </summary>
        /// <param name="saveObject">Сохраняемый объект</param>
        /// <param name="pathToFile">Путь до файла</param>
        public static void SaveObjectToFile(Object saveObject, string pathToFile)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, saveObject);
            }
        }
    }
}