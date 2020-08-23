using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanCongGiangDay.Respository
{
   public interface IRespository<T> where T:class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Save();
        T GetById(int Id);
    }
}
