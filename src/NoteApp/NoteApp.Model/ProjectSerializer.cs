using Newtonsoft.Json;
using System.IO;
using System;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс, реализующий сохранение и загрузку.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Название файла сохранения.
        /// </summary>
        private const string _fileName = "NoteApp.note";

        /// <summary>
        /// Путь к папке сохранения.
        /// </summary>
        private static readonly string _folder = Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData) +
            "\\Izbyshev_NoteApp\\";

        /// <summary>
        /// Полный путь директории сохранения.
        /// </summary>
        private static readonly string _path = _folder + _fileName;

        /// <summary>
        /// Путь сохранения.
        /// </summary>
        public static string SavePath { get; set; } = _path;

        /// <summary>
        /// Создает файл.
        /// </summary>
        /// <param name="folder">Папка сохранения</param>
        /// <param name="fileName">Имя файла</param>
        public static void CreatePath(string folder, string fileName)
        {
            if (folder == null)
            {
                folder = _folder;
            }
            if (fileName == null)
            {
                fileName = _fileName;
            }
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            if (!File.Exists(folder + fileName))
            {
                File.Create(folder + fileName).Close();
            }
            SavePath = folder + fileName;
        }

        /// <summary>
        /// Сохраненяет в файл.
        /// </summary>
        /// <param name="data">Данные проекта</param>
        public static void SaveToFile(Project data)
        {
            if (!File.Exists(SavePath))
            {
                CreatePath(_folder, _fileName);
            }
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (var sw = new StreamWriter(SavePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Загрузка проекта из файла.
        /// </summary>
        /// <returns>
        /// Возвращает загруженный проект из файла.
        /// </returns>
        public static Project LoadFromFile()
        {
            var serializer = new JsonSerializer();
            try
            {
                using (var sr = new StreamReader(SavePath))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    var project = (Project)serializer.Deserialize<Project>(reader);
                    if (project == null)
                    {
                        return new Project();
                    }

                    return project;
                }
            }
            catch
            {
                return new Project();
            }
        }
    }
}
