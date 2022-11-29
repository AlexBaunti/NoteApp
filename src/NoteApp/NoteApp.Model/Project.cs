using System.Collections.Generic;
using System.Linq;

namespace NoteApp.Model
{
    /// <summary>
    /// Класс,который хранит все заметки.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Конструктор проекта.
        /// </summary>
        public Project()
        {
            Notes = new List<Note>();
        }

        /// <summary>
        /// Список с заметками.
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Функция сортировки всех заметок по дате редактирования.
        /// </summary>
        /// <param name="notes">Передаваемый список заметок</param>
        public List<Note> SortByModificationTime(List<Note> notes)
        {
            notes = notes.OrderByDescending(note =>
                note.ModifiedTime).ToList();
            return notes;
        }

        /// <summary>
        /// Функция поиска заметок по категории.
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
