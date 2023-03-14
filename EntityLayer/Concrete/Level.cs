using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Level
    {
        [Key]
        public int LevelID { get; set; }      
        public string level { get; set; }
        public string Price { get; set; }
        //language
        public int? LanguageID { get; set; }
        public virtual Language Language { get; set; }
        
        public ICollection<Book> Books { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
