using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesWebApp.Models;

namespace NotesWebApp.Services
{
    public class NoteService : INoteInterface
    {
        public List<Note> AllNotes { get; set; }
        public NoteService()
        {
            AllNotes = new List<Note>();

            AllNotes.Add(new Note() { Id = 01, Title = "Addition Notes", Body = "notes about how to add small and large numbers", DateCreated = DateTime.Now, Folder = "Math" });

            AllNotes.Add(new Note() { Id = 02, Title = "Multiplication Notes", Body = "Multiplaction is similar to addition.  It is repeated addition", DateCreated = DateTime.Now, Folder = "Math" });

            AllNotes.Add(new Note() { Id = 03, Title = "Battle of Bulge", Body = "Depicted in many movies to include 'band of brothers'", DateCreated = DateTime.Now, Folder = "History" });

            AllNotes.Add(new Note() { Id = 04, Title = "Chemical Composition", Body = "Water molecule is two parts hydrogen, one part oxygen ", DateCreated = DateTime.Now, Folder = "Science" });

            AllNotes.Add(new Note() { Id = 05, Title = "Adverbs", Body = "Most adverbs will end in 'ly.' Words like 'longingly, quickly, terribly'", DateCreated = DateTime.Now, Folder = "English" });


        }

    }   
    

    
}
