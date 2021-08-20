using NotesWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesWebApp.Services
{
    public interface INoteInterface
    {
        List<Note> AllNotes { get; set; }

    }
}
