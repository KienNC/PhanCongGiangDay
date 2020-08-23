using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PhanCongGiangDay.DataModel;
using PhanCongGiangDay.Models;
using PhanCongGiangDay.Respository;

namespace PhanCongGiangDay.Service
{
    public class BoMonService : IBoMonService
    {
        private readonly Respository<DmBoMon> _dmBoMonRespository;
        public BoMonService()
        {
            this._dmBoMonRespository =  new Respository<DmBoMon>() ;
        }
        public IList<DmBoMon> GetAllBoMon()
        {
            List<DmBoMon> ListItem = _dmBoMonRespository.GetAll().ToList();
            return ListItem.ToList();
        }

        public DmBoMon GetBoMonById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}