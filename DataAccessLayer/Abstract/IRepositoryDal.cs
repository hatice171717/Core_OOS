using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T>
    {
        //CRUD
        //Type Name();
        //Listeleme
        List<T> List();
        //Ekleme
        void Insert(T p);
        //Silme
        void Delete(T p);
        //Güncelle
        void Update(T p);
        //Şartlı Listeleme
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
