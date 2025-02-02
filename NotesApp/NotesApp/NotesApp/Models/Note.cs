﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NotesApp.Models
{
    internal class Note
    {
        public Note(string title, string description)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new InvalidOperationException(nameof(title));
            }
            Title = title;
            Description = description;
        }
        public Guid Id { get; }
        public string Title { get; }
        public string Description { get; }
    }
}
