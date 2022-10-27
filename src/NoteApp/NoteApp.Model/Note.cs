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
        /// Название по умолчанию.
        /// </summary>
        private const string DEFAULTTITLE = "Без Названия";

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
            get { return _title; }

            set
            {
                if (value.Length > NOTETITLELIMIT)
                {
                    throw new ArgumentException("max title length = 50");
                }
                if (value == string.Empty)
                {
                    _title = DEFAULTTITLE;
                }

                _title = value;
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Get и Set текста.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                _modifiedTime = DateTime.Now;
            }
        }

        /// <summary>
        /// Возвращает дату создания заметки
        /// </summary>
        public DateTime CreateTime
        {
            get
            {
                return _creationDate;
            }
        }

        /// <summary>
        /// Возвращает дату изменения заметки
        /// </summary>
        public DateTime ModifiedTime
        {
            get
            {
                return _modifiedTime;
            }
        }

        /// <summary>
		/// Задает и возвращает категорию заметки.
		/// </summary>
		public NoteCategory Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
                _modifiedTime = DateTime.Now;
            }
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
            return new Note(this.Title, this.Category, this.Text);
        }
    }
}
