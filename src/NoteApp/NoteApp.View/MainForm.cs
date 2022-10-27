using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp.Model;

namespace NoteApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения объектов заметок.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Показывать все заметки без учета категории.
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// Отображает списка заметок.
        /// </summary>
        private List<Note> _currentNotes;

        public MainForm()
        {
            InitializeComponent();
            _project = new Project();
            ///_project = ProjectSerializer.LoadFromFile();
            _currentNotes = _project.Notes;
            CategoryComboBox.SelectedIndex = 0;
            ClearSelectedNote();
            UpdateListBox();
        }

        /// <summary>
        /// Добавить заметку.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.ShowDialog();
            if (noteForm.DialogResult == DialogResult.OK)
            {
                _project.Notes.Add(noteForm.Note);
                OutputByCategory();
                UpdateListBox();
                CategoryListBox.SelectedIndex = -1;
                ///ProjectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// Редактировать заметку.
        /// </summary>
        private void EditNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _currentNotes[index];
            index = FindNoteIndex(index);
            NoteForm noteForm = new NoteForm();
            noteForm.Note = _project.Notes[index];
            noteForm.ShowDialog();
            _project.Notes[index] = noteForm.Note;
            if (noteForm.DialogResult == DialogResult.OK)
            {
                currentIndex = -1;
                OutputByCategory();
                UpdateSelectedNote(CategoryListBox.SelectedIndex);
                UpdateListBox();
                ///ProjectSerializer.SaveToFile(_project);
            }
            if ((CategoryListBox.Items.Count != 0) && (currentIndex < CategoryListBox.Items.Count))
            {
                CategoryListBox.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Удалить заметку.
        /// </summary>
        private void RemoveNote(int index)
        {
            if (index == -1)
            {
                return;
            }
            int currentIndex = index;
            Note note = _project.Notes[index];
            index = FindNoteIndex(index);
            var result = MessageBox.Show("Do you really want to remove " + "\"" + CategoryListBox.SelectedItem.ToString()
                + "\"" + "?", "Deleting a note", MessageBoxButtons.OKCancel, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(index);
                ClearSelectedNote();
                OutputByCategory();
                UpdateListBox();
                ///ProjectSerializer.SaveToFile(_project);
            }
            if ((CategoryListBox.Items.Count != 0) && (currentIndex < CategoryListBox.Items.Count))
            {
                CategoryListBox.SelectedIndex = currentIndex;
            }
        }

        /// <summary>
        /// Метод для заполнения.
        /// </summary>
        private void UpdateSelectedNote(int index)
        {
            if ((index == -1) || (_currentNotes.Count == 0) || (_currentNotes.Count <= index))
            {
                ClearSelectedNote();
                return;
            }
            Note note = _currentNotes[index];
            NoteTextBox.Text = note.Text;
            TextLabel.Text = Enum.GetName(typeof(NoteCategory), note.Category);
            NameLabel.Text = note.Title;
            DateTimePickerCreated.Visible = true;
            DateTimePickerModified.Visible = true;
            DateTimePickerCreated.Value = note.CreateTime;
            DateTimePickerModified.Value = note.ModifiedTime;
        }

        /// <summary>
        /// Метод для очистки.
        /// </summary>
        private void ClearSelectedNote()
        {
            NameLabel.Text = "";
            NoteTextBox.Text = "";
            TextLabel.Text = "";
            DateTimePickerCreated.Visible = false;
            DateTimePickerModified.Visible = false;
        }

        /// <summary>
        /// Метод обновления.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryListBox.SelectedIndex == -1)
            {
                ClearSelectedNote();
            }
            else
            {
                UpdateSelectedNote(CategoryListBox.SelectedIndex);
            }
        }

        /// <summary>
        /// Вывод на экран списка заметок по выбранной категории.
        /// </summary>
        private void OutputByCategory()
        {
            if (CategoryComboBox.SelectedItem.ToString() != _allCategory)
            {
                NoteCategory noteCategory = new NoteCategory();
                foreach (var category in Enum.GetValues(typeof(NoteCategory)))
                {
                    if (CategoryComboBox.SelectedItem.ToString() == category.ToString())
                    {
                        noteCategory = (NoteCategory)category;
                    }
                }
                _currentNotes = _project.SearchByCategory(_project.Notes, noteCategory);
            }
            else
            {
                _currentNotes = _project.SortByModificationTime(_project.Notes);
            }
        }

        /// <summary>
        /// Поиск индекса в списке заметок по индексу заметки из текущей категории.
        /// </summary>
        private int FindNoteIndex(int index)
        {
            return _project.Notes.IndexOf(_currentNotes[index]);
        }

        /// <summary>
        /// Обновляет список заметок в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CategoryListBox.Items.Clear();
            _currentNotes = _project.SortByModificationTime(_currentNotes);
            for (int i = 0; i < _currentNotes.Count; i++)
            {
                CategoryListBox.Items.Add(_currentNotes[i].Title);
            }
        }

        /// <summary>
        /// Обработчик изменения выбранной заметки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedNote(CategoryListBox.SelectedIndex);
        }

        /// <summary>
        /// Добавление новой заметки через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование заметки через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Удаление заметки через меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Окно About.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                AboutForm af = new AboutForm();
                af.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Добавление заметки через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconButtonAdd_Click(object sender, EventArgs e)
        {
            AddNote();
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование заметки через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconButtonEdit_Click(object sender, EventArgs e)
        {
            EditNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Редактирование заметки через кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconButtonDel_Click(object sender, EventArgs e)
        {
            RemoveNote(CategoryListBox.SelectedIndex);
            UpdateListBox();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSelectedNote();
            OutputByCategory();
            UpdateListBox();
        }
    }
}
