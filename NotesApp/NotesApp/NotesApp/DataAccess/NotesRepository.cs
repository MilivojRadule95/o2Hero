using NotesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotesApp.DataAccess
{
    internal class NotesRepository
    {
        public NotesRepository()
        {
            _notes.Add(new Note("naslov", "opis"));
            _notes.Add(new Note("Brkata zena", "Problem sa hormonima"));
        }
        private List<Note> _notes = new List<Note>();

        public void AddNote(Note note)
        {
            _notes.Add(note);
        }

        public void DeleteNote(Guid id)
        {
            _notes = _notes.Where(note => note.Id != id).ToList();
        }
        public IEnumerable<Note> GetAllNotes()
        {
            return new List<Note>();
        }
    }
}
