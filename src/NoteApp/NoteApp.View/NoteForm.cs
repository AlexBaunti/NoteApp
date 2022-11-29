﻿using System;
using System.Drawing;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{// TODO: xml
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
        private string _titleError;

        /// <summary>
        /// Константа для корректного цвета. 
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Константа для цвета ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightCoral;
        
        public NoteForm()
        {
            InitializeComponent();
            foreach (var value in Enum.GetValues(typeof(NoteCategory)))
            {
                // TODO: не надо делать ToString()
                CategoryComboBox.Items.Add(value.ToString());
            }
            TitleTextBox.Text = "Unnamed Note";
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
            // TODO: GetValue
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
                // TODO: Не надо делать ToString()
                if (CategoryComboBox.SelectedItem.ToString() == category.ToString())
                {
                    _noteCopy.Category = (NoteCategory)category;
                }
            }
            _noteCopy.Title = TitleTextBox.Text;
            _noteCopy.Text = NoteTextBox.Text;
        }

        /// <summary>
        /// Метод обработки и присвоение названия заметке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _noteCopy.Title = TitleTextBox.Text;
                TitleTextBox.BackColor = _correctColor;
                _titleError = null;
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _errorColor;
                _titleError = exception.Message;
            }
        }

        /// <summary>
        /// Проверка на наличие ошибок в форме.
        /// </summary>
        private bool CheckFormOnErrors()
        {
            if (_titleError == null)
            {
                return true;
            }
            else
            {
                MessageBox.Show(_titleError);
                return false;
            }
        }

        /// <summary>
        /// Индикация ошибки списка категорий.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_Click(object sender, EventArgs e)
        {
            CategoryComboBox.BackColor = _correctColor;
        }

        /// <summary>
        /// Закрыть форму без сохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // TODO: Saving - это про сохранение (например, в файл). А то, что у тебя, сопровождается надписью "Все изменения будут потеряны. Продолжить?"
            DialogResult dialogResult = MessageBox.Show("Continue without Saving?","Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == -1)
            {
                CategoryComboBox.BackColor = _errorColor;
                MessageBox.Show("Choose Category from List");
                return;
            }

            if (CheckFormOnErrors())
            {
                UpdateNote();
                _note = _noteCopy;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                return;
            }
        }
    }
}
