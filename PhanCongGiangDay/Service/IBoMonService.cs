using PhanCongGiangDay.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanCongGiangDay.Service
{
   public interface IBoMonService
    {
        IList<DmBoMon> GetAllBoMon();
        DmBoMon GetBoMonById(int Id);

    }
}
