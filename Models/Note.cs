using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NotesWebApp.Models
{
    public class Note
    {
        [Required]
        [Display(Name = "Note ID: ")]
        public int Id { get; set; }
        
        
        [Required]
        [StringLength(20)]
        [Display(Name = "Title: ")]
        public string Title { get; set; }
        

        [Required(ErrorMessage ="Creating a new note requires a body.")]
        [Display(Name = "Body")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        
        
        [DataType(DataType.Date)]
        [Display(Name = "Date: ")]        
        public DateTime DateCreated { get; set; }
        
         
        [Required(ErrorMessage = "Notes need to be categorized into a folder")]
        [Display(Name = "Folder: ")]        
        public string Folder { get; set; }
    }
}
