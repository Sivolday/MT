using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MT.SharedComponents
{
    /// <summary> Хранитель настоек и состояния приложения </summary>
    public static class KeeperApplicationCondition
    {
        private static readonly Func<object, string> _jsonConvert = objectForConvertation =>
            Newtonsoft.Json.JsonConvert.SerializeObject
            (
                objectForConvertation,
                Formatting.Indented,
                new JsonSerializerSettings ()
            );


        /// <summary> Загрузить файл </summary>
        /// <typeparam name="T"> Кастуемый тип </typeparam>
        /// <param name="pathToFile">Пусть до файл</param>
        /// <returns>Объект</returns>
        public static T LoadFromFile<T>(string pathToFile)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(pathToFile));
        }

        /// <summary> Сохранение объекта на диск </summary>
        /// <param name="saveObject">Сохраняемый объект</param>
        /// <param name="pathToFile">Путь до файла</param>
        public static void SaveObjectToFile(Object saveObject, string pathToFile)
        {
            File.WriteAllText(pathToFile, _jsonConvert(saveObject));
        }
    }
}