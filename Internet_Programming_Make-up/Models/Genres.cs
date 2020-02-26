using System;
using System.Collections.Generic;

namespace Internet_Programming_Make_up.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Books = new HashSet<Books>();
        }

        public int Id { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
