using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Переменная заметки.
        /// </summary>
        private Note _note = new Note();

        /// <summary>
        /// Переменная заметки.
        /// </summary>
        private Note _noteCopy = new Note();

        /// <summary>
        /// Строка для вывода ошибки.
        /// </summary>
        private string _noteError;

        /// <summary>
        /// Константа для корректного цвета. 
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Константа для цвета ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;
        
        public NoteForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Задает и возвращает объект заметки.
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
                if (_note != null)
                {
                    _noteCopy = (Note)_note.Clone();
                }
                else
                {
                    _noteCopy = new Note();
                }
                UpdateForm();
            }
        }

        /// <summary>
        /// Метод обновления формы.
        /// </summary>
        private void UpdateForm()
        {
            CategoryComboBox.SelectedItem = Enum.GetName(typeof(NoteCategory), _noteCopy.Category);
            TitleTextBox.Text = _noteCopy.Title;
            DateTimePickerCreated.Value = _noteCopy.CreateTime;
            DateTimePickerModified.Value = _noteCopy.ModifiedTime;
            NoteTextBox.Text = _noteCopy.Text;
        }

        /// <summary>
        /// Метод обновления заметки.
        /// </summary>
        private void UpdateNote()
        {
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                if (CategoryComboBox.SelectedItem.ToString() == category.ToString())
                {
                    _noteCopy.Category = (NoteCategory)category;
                }
            }
            _noteCopy.Title = TitleTextBox.Text;
            _noteCopy.Text = NoteTextBox.Text;
        }

        /// <summary>
        /// Метод обработки и валидации названия заметки.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteCopy.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _correctColor;
                _noteError = "";
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _errorColor;
                _noteError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на наличие ошибок в форме.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if (_noteError != "")
            {
                MessageBox.Show(_noteError);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
