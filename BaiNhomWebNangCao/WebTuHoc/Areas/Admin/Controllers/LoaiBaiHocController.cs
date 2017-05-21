using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;

namespace WebTuHoc.Areas.Admin.Controllers
{
    public class LoaiBaiHocController : Controller
    {
        // GET: Admin/LoaiBaiHoc
        public ActionResult Index()
        {
            ModelController<LoaiBaiHoc> lbh = new EFController.LoaiBaiHocController();
            var lsLbh = lbh.SelectAll();
            return View(lsLbh);
        }
        [HttpPost]
        public ActionResult Create()
        {
            
            return View();
        }

        private EFController.LoaiBaiHocController GetLoaiBaiHoc()
        {
            return null;
        }
    }
}