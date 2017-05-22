using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;

namespace WebTuHoc.Areas.Admin.Controllers
{
    public class LoaiBaiHocController : DefaultController<LoaiBaiHoc>
    {
        // GET: Admin/LoaiBaiHoc
        public override ActionResult Create()
        {
            ModelController<LoaiBaiHoc> Mlbh = new EFController.LoaiBaiHocController();
            ViewData["LoaiBHs"] = Mlbh.SelectAll();
            return View();
        }


        public override ActionResult Edit(int id)
        {
            ModelController<LoaiBaiHoc> Mlbh = new EFController.LoaiBaiHocController();
            var lbh = Mlbh.SelectWhere("IdLBH == " + id).FirstOrDefault();
            ViewData["LoaiBHs"] = Mlbh.SelectAll();
            return View(lbh);
        }

    }
}