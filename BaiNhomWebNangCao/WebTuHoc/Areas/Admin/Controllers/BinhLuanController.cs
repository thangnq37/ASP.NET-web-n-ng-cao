using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;

namespace WebTuHoc.Areas.Admin.Controllers
{
    public class BinhLuanController : DefaultController<BinhLuan>
    {
        // GET: Admin/BinhLuan
        public override ActionResult Create()
        {
            ModelController<BinhLuan> Mlbh = new EFController.BinhLuanController();
            ViewData["LoaiBHs"] = Mlbh.SelectAll();
            return View();
        }
    }
}