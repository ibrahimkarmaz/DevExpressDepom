using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Note
    {
        public int NoteID { get; set; } 
        public DateTime NoteDate { get; set; } 
        public DateTime NoteHour { get; set; } 
        public string NoteTitle { get; set; } 
        public string NoteDetail { get; set; } 
        public string NoteCreate { get; set; } 
        public bool NoteArchive { get; set; } 
    }
}
