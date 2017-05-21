using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;

namespace WebTuHoc.Areas.Admin.Controllers
{
    public class UserController : DefaultController<Users>
    {
        // GET: Admin/User
        public override ActionResult Create()
        {
            ModelController<Users> Mlbh = new EFController.UsersController();
            return View();
        }
    }
}