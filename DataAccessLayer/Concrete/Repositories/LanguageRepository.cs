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
            throw new NotImplementedException();
        }

        public void Insert(Language p)
        {
            throw new NotImplementedException();
        }

        public List<Language> List()
        {
            return _object.ToList();
        }

        public void Update(Language p)
        {
            throw new NotImplementedException();
        }
    }
}
//ToList
//Add
//Remove
//Find