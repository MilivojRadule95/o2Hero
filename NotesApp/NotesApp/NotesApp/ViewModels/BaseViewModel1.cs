using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NotesApp.ViewModels
{
    internal class BaseViewModel1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
