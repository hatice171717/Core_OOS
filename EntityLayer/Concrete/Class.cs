using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }
        public string ClassName { get; set; }

        public int? OfficeID { get; set; }
        public virtual Office Office { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
