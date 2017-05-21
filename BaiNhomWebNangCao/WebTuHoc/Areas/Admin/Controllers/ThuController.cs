using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;

namespace WebTuHoc.Areas.Admin.Controllers
{
    public class ThuController : Controller
    {
        // GET: Admin/Thu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            ModelController<LoaiBaiHoc> lbh = new EFController.LoaiBaiHocController();
            var lsLbh = lbh.SelectAll();
            return View(lsLbh);
        }
    }
}