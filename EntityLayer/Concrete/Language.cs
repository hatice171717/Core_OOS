using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        public string language { get; set; }

        public ICollection<Level> Levels { get; set; }
        public ICollection<Book> Books { get; set; }
        public ICollection<Educator> Educators { get; set; }
        public ICollection<Sale> Sales { get; set; }

    }
}
