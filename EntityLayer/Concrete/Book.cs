using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
              
        public string BookName { get; set; }
        public string Writer { get; set; }
        public string Price { get; set; }
        //language
        public int? LanguageID { get; set; }
        public virtual Language Language { get; set; }
        //level
        public int? LevelID { get; set; }
        public virtual Level Level { get; set; }

        public ICollection<Sale> Sales { get; set; }

    }
}
