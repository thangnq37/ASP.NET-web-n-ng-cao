using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;

namespace WebTuHoc.Areas.Admin.Controllers.table
{
    public class BaiHocController : DefaultController<BaiHoc>
    {
        // GET: Admin/BaiHoc
        public override ActionResult Create()
        {
            ModelController<LoaiBaiHoc> listLBH = new EFController.LoaiBaiHocController();
            var lsLBH = listLBH.SelectAll();
            ViewData["lsLBH"] = lsLBH;
            return View();
        }

    }
}