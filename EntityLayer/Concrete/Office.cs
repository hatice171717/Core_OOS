using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Office
    {
        [Key]
        public int OfficeID { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string Address { get; set; }
        public ICollection<Class> Classes { get; set; }

    }
}
