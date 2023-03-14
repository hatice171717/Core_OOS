using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Educator
    {
        [Key]
        public int EducatorID { get; set; }
        public string EducatorNameSurname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        //language
        public int? LanguageID { get; set; }
        public virtual Language Language { get; set; }
    }
}
