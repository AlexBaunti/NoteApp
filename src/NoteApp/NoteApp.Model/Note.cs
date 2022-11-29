using System;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс заметки.
    /// </summary>
    public class Note: ICloneable
    {
        /// <summary>
        /// Ограничение длины названия.
        /// </summary>
        private const int NOTETITLELIMIT = 50;

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
        public DateTime _creationDateTime = DateTime.Now;

        /// <summary>
        /// Дата последнего изменения.
        /// </summary>
        public DateTime _modifiedTime;
        
        /// <summary>
        /// Категория заметки.
        /// </summary>
        public NoteCategory _category;

        /// <summary>
        /// Метод копирования.
        /// </summary>
        public object Clone()
        {
            return new Note(Title, Category, Text);
        }

        /// <summary>
        /// Задает и возвращает название заметки.
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                if (value.Length > NOTETITLELIMIT)
                {
                    throw new ArgumentOutOfRangeException("Max Title Length 50 Symbols");
                }
                if(value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Title Must Be Filled");
                }
                _title = value;
            }
        }

        /// <summary>
		/// Задает и возвращает категорию заметки.
		/// </summary>
		public NoteCategory Category
        {
            get => _category;
            set
            {
                _category = value;
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Задаёт и возвращает текст заметки.
        /// </summary>
        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает дату создания заметки
        /// </summary>
        public DateTime CreationDateTime => _creationDateTime;

        /// <summary>
        /// Возвращает дату изменения заметки
        /// </summary>
        public DateTime ModifiedTime => _modifiedTime;

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

        /// <summary>
        /// Конструктор для новой заметки.
        /// </summary>
        public Note()
        {
        }
    }
}
