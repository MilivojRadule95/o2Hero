using NotesApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotesApp.ViewModels
{
    internal class NoteViewModel : BaseViewModel1
    {
        
        private string _title;
        private string _description;
        
        public NoteViewModel(Note note)
        {
            Title = note.Title;
            Description = note.Description;
        }

        
        public string Description 
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }

            
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }


        }
    }
}
