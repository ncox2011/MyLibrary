using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Patron
    {
        [Key]
        public int PatronId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string LibraryCardNum { get; set; }

        [Display(Name = "Library")]
        public int LibraryId { get; set; }

        public Library Library { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
