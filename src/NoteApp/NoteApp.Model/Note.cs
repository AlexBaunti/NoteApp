using System;

namespace NoteApp.Model
{
    /// <summary>
    /// Заметка.
    /// </summary>
    public class Note: ICloneable
    {
        /// <summary>
        /// Ограничение длины названия.
        /// </summary>
        private const int NOTETITLELIMIT = 50;

        /// <summary>
        /// Ограничение длины названия.
        /// </summary>
        private const string DEFAULTTITLE = "Unnamed Note";

        /// <summary>
        /// Название заметки.
        /// </summary>
        private string _title;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime _creationDate = DateTime.Now;

        /// <summary>
        /// Дата последнего изменения.
        /// </summary>
        public DateTime _modifiedTime;
        
        /// <summary>
        /// Категория заметки.
        /// </summary>
        public NoteCategory _category;

        /// <summary>
        /// Get и Set названия.
        /// </summary>
        public string Title
        {
            set
            {
                if (value.Length > NOTETITLELIMIT)
                {
                    throw new ArgumentOutOfRangeException("Max Title Length = 50");
                }
                if(value.Length == 0)
                {
                    value = DEFAULTTITLE;
                }
                _title = value;
            }
            get => _title;
        }

        /// <summary>
        /// Get и Set текста.
        /// </summary>
        public string Text
        {
            set
            {
                _text = value;
                _modifiedTime = DateTime.Now;
            }
            get => _text;
        }

        /// <summary>
        /// Возвращает дату создания заметки
        /// </summary>
        public DateTime CreateTime => _creationDate;

        /// <summary>
        /// Возвращает дату изменения заметки
        /// </summary>
        public DateTime ModifiedTime => _modifiedTime;

        /// <summary>
		/// Задает и возвращает категорию заметки.
		/// </summary>
		public NoteCategory Category
        {
            set
            {
                _category = value;
                _modifiedTime = DateTime.Now;
            }
            get => _category;
        }

        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        /// <param name="creationDate"></param>
        /// <param name="modifiedTime"></param>
        public Note(string name, NoteCategory category, string text,
            DateTime creationDate, DateTime modifiedTime) =>
            (_title, _category, _text, _creationDate, _modifiedTime)
            = (name, category, text, creationDate, modifiedTime);

        /// <summary>
        /// Создает экземпляр заметки.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="text"></param>
        public Note(string name, NoteCategory category, string text)
        {
            Title = name;
            Category = category;
            Text = text;
        }

        public Note()
        {
        }

        /// <summary>
        /// Метод копирования.
        /// </summary>
        public object Clone()
        {
            return new Note(Title, Category, Text);
        }
    }
}
