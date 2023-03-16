using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ILanguageDAL
    {
        //CRUD
        //Type Name();
        //Listeleme
        List<Language> List();
        //Ekleme
        void Insert(Language p);
        //Güncelleme
        void Update(Language p);    
        //Silme
        void Delete(Language p);
       
    }
}
