using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }
        //Student
        public int? StudentID { get; set; }
        public virtual Student Student { get; set; }
        //language
        public int? LanguageID { get; set; }
        public virtual Language Language { get; set; }
        //level
        public int? LevelID { get; set; }
        public virtual Level Level { get; set; }
        //Book
        public int? BookID { get; set; }
        public virtual Book Book { get; set; }
        //Class
        public int? ClassID { get; set; }
        public virtual Class Class { get; set; }
    }
}
