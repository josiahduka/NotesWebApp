using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesWebApp.Models;
using NotesWebApp.Services;
using NotesWebApp.Data;

namespace NotesWebApp.Controllers
{
    public class NoteController : Controller
    {
        private NoteContext data;

        public NoteController(NoteContext note)
        {
            data = note;
        }
       

        public IActionResult Index()
        {
            return View();
        }
        //Add to notes(get and post), view all notes, view a note, edit notes, delete notes

        //Displays all notes
        public IActionResult DisplayAllNotes()
        {
            return View(data.NotesCollectionDB.ToList());
        }
        
        //show a single note stored locally
        public IActionResult DisplayNote(int id)
        {
            Note a_note = data.NotesCollectionDB.SingleOrDefault(_note => _note.Id == id);

            if (a_note == null)
                return NotFound();

            return View(a_note);
        }

        [HttpGet]
        public IActionResult AddNote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }

            //data comes from constructor in this class
            //note is the object passed through the method
            data.Add(note);
            
            //saves changes, must have to update the database
            data.SaveChanges();
            
            return RedirectToAction("DisplayAllNotes");

        }


        [HttpGet]
        public IActionResult EditNote(int id)
        {
            Note aNote = data.NotesCollectionDB.SingleOrDefault(stored => stored.Id == id);
            
            if (aNote == null)
                return NotFound();

            return View(aNote);

        }

        [HttpPost]
        public IActionResult EditNote(Note note)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Note updated_note = data.NotesCollectionDB.SingleOrDefault(_note => _note.Id == note.Id);
            updated_note.Title = note.Title;
            updated_note.Body = note.Body;
            updated_note.DateCreated = note.DateCreated;
            updated_note.Folder = note.Folder;

            data.NotesCollectionDB.Update(updated_note);

            data.SaveChanges();

            return RedirectToAction("DisplayAllNotes");
            


        }
        public IActionResult DeleteNote(int id)
        {
            Note a_note = data.NotesCollectionDB.SingleOrDefault(_note => _note.Id == id);

            if (a_note == null)
                return NotFound();

            data.NotesCollectionDB.Remove(a_note);
            data.SaveChanges();



            return RedirectToAction("DisplayAllNotes");
        }







    }
}
