using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class LanguageRepository : ILanguageDAL
    {
       Context c = new Context();
       DbSet<Language> _object;

        public void Delete(Language p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Language p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Language> List()
        {
            return _object.ToList();
        }

        public void Update(Language p)
        {
            c.SaveChanges();
        }
    }
}
//ToList
//Add
//Remove
//Find