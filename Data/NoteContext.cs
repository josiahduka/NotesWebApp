using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotesWebApp.Models;

namespace NotesWebApp.Data
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)
        {

        }

        public DbSet<Note> NotesCollectionDB { get; set; }


        //populates the table with initial da
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note() { Id = 01, Title = "Addition Notes", Body = "notes about how to add small and large numbers", DateCreated = DateTime.Now, Folder = "Math" },
                new Note() { Id = 02, Title = "Multiplication Notes", Body = "Multiplaction is similar to addition.  It is repeated addition", DateCreated = DateTime.Now, Folder = "Math" },
                new Note() { Id = 03, Title = "Battle of Bulge", Body = "Depicted in many movies to include 'band of brothers'", DateCreated = DateTime.Now, Folder = "History" },
                new Note() { Id = 04, Title = "Chemical Composition", Body = "Water molecule is two parts hydrogen, one part oxygen ", DateCreated = DateTime.Now, Folder = "Science" }

                );
        }
    }
}
