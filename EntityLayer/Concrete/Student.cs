using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Identity { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public Boolean State { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
