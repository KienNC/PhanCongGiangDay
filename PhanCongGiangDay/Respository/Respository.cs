using PhanCongGiangDay.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhanCongGiangDay.Respository
{
    public class Respository<T> : IRespository<T> where T : class
    {
        internal PhanCongGiangDayEntities _context = null;
       internal DbSet<T> table = null;

        public Respository()
        {
            this._context = new PhanCongGiangDayEntities();
            //this._context.Configuration.ValidateOnSaveEnabled = false;
            this.table = _context.Set<T>();
        }
        public Respository(PhanCongGiangDayEntities context)
        {
            this._context = context;
         this.table = context.Set<T>();
        }
        public virtual T GetById(int Id)
        {
            return table.Find(Id);
        }
     
        public virtual IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public virtual  void Insert(T entity)
        {
            table.Add(entity);
            Save();
        }

        public virtual void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex )
            {

                throw ex;
            }           
        }
        public virtual void Update(T entity)
        {
            table.Attach(entity);
            Save();
        }
        public virtual void Delete(T entity)
        {
            table.Remove(entity);
            Save();
        }
    }
}