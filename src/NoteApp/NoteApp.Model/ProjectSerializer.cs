using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс, реализующий сохранение и загрузку
    /// </summary>
    public static class ProjectSerializer
    {
        private const string _fileName = "NoteApp.note";

        private static readonly string _folder = Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData) +
            "\\Izbyshev_NoteApp\\";

        private static readonly string _path = _folder + _fileName;

        public static string DefaultPath { get; set; } = _path;

        public static void SaveToFile(Project data)
        {
            if (!File.Exists(DefaultPath))
            {
                CreatePath(_folder, _fileName);
            }
            var serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            using (var sw = new StreamWriter(DefaultPath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Создает файл
        /// </summary>
        /// <param name="folder">File location</param>
        /// <param name="fileName">File name</param>
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
            DefaultPath = folder + fileName;
        }

        /// <summary>
        /// Загрузка проекта из файла.
        /// </summary>
        /// <returns>
        /// Возвращает загруженный проект из файла
        /// </returns>
        public static Project LoadFromFile()
        {
            var serializer = new JsonSerializer();
            try
            {
                using (var sr = new StreamReader(DefaultPath))
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
