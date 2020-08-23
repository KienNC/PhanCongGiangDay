using PhanCongGiangDay.DataModel;
using PhanCongGiangDay.Models;
using PhanCongGiangDay.Respository;
using PhanCongGiangDay.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhanCongGiangDay.Controllers
{
    public class DmBoMonController : Controller
    {
        private BoMonService _boMonService;
        public DmBoMonController()
        {
            this._boMonService = new BoMonService();
        }
        // GET: DmBoMon
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            List<DmBoMonModel> dmBoMonModels = new List<DmBoMonModel>();
            var ListItem = _boMonService.GetAllBoMon();
            foreach (var item in ListItem)
            {
                DmBoMonModel model = new DmBoMonModel();
                model.Id = item.Id;
                model.MaBoMon = item.MaBoMon;
                model.TenBoMon = item.TenBoMon;
                model.ThongTinBoMon = item.ThongTinBoMon;
                dmBoMonModels.Add(model);
            }
            return View(dmBoMonModels);
        }
    }
}