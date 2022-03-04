using NotesApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace NotesApp.ViewModels
{
    internal class MainViewModel : BaseViewModel1
    {
        public MainViewModel()
        {
            AddNoteCommand = new Command(OnAddNoteCommand);
            LoadNotes();
        }

        private void LoadNotes()
        {
            //var notesViewModel = new List<NoteViewModel>();

            //foreach (var note in notes)
            //{
            //    notesViewModel.Add(new NoteViewModel(note));
            //}

            var notes = _notesRepository.GetAllNotes().Select(n => new NoteViewModel(n));

            NotesSource = new ObservableCollection<NoteViewModel>(notes);
        }

        private readonly NotesRepository _notesRepository = new NotesRepository();
        private ObservableCollection<NoteViewModel> _notesSource;

        public ObservableCollection<NoteViewModel> NotesSource
        {
            get { return _notesSource; }
            set 
            { 
                _notesSource = value; 
                OnPropertyChanged(nameof(NotesSource));
            }
        }

        public ICommand AddNoteCommand { get; }

        private void OnAddNoteCommand()
        {
            throw new NotImplementedException();
        }
    }
}
