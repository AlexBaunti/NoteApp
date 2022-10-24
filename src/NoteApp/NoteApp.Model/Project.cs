using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс,который хранит все заметки
    /// </summary>
    public class Project
    {
        public Project()
        {
            Notes = new List<Note>();
        }
        /// <summary>
        /// Список с заметками
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        // <summary>
        /// Функция сортировки всех заметок по убыванию
        /// </summary>
        public List<Note> SortByModificationTime(List<Note> notes)
        {
            notes = notes.OrderByDescending(note =>
                note.ModifiedTime).ToList();
            return notes;
        }

        /// <summary>
        /// Функция выборки всех заметок по передаваемой категории
        /// </summary>
        /// <param name="notes">Передаваемый список заметок</param>
        /// <param name="noteCategory">Передаваемая категория заметки</param>
        /// <returns></returns>
        public List<Note> SearchByCategory(List<Note> notes, NoteCategory noteCategory)
        {
            notes = Notes.Where(note =>
                note.Category == noteCategory).ToList();
            return notes;
        }
    }
}
