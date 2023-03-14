using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Educator> Educators { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
