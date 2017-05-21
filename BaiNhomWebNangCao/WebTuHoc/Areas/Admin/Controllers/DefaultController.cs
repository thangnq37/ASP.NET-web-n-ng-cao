using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using EFController;
namespace WebTuHoc.Areas.Admin.Controllers
{
    public abstract class DefaultController<m> : Controller where m : class, new() 
    {
        private object GetController()
        {
            m t = new m();
            if (t is LoaiBaiHoc)
                return new EFController.LoaiBaiHocController();
            else if (t is BaiHoc)
                return new EFController.BaiHocController();
            else if (t is BinhLuan)
                return new EFController.BinhLuanController();
            else if (t is Images)
                return new EFController.ImagesControler();
            else if (t is Like)
                return new EFController.LikeController();
            else
                return new EFController.UsersController();
        }
        // GET: Admin/Default
        public virtual ActionResult Index()
        {
            ModelController<m> list = GetController() as ModelController<m>;
            var ls = list.SelectAll();
            return View(ls);
        }
        public virtual ActionResult Create()
        {
            ModelController<m> list = GetController() as ModelController<m>;
            return View();
        }
        [HttpPost]
        public virtual ActionResult Create(m lbh)
        {
            ModelController<m> list = GetController() as ModelController<m>;
            list.Insert(lbh);
            return RedirectToAction("index");
        }

        public virtual ActionResult Edit(int id)
        {
            ModelController<m> list = GetController() as ModelController<m>;
            var lbh = list.SelectWhere("IdLBH == " + id).FirstOrDefault();
            return View(lbh);
        }
        [HttpPost]
        public virtual ActionResult Edit(m lbh)
        {
            ModelController<m> list = GetController() as ModelController<m>;
            
            var a = RouteData.Values["id"];
            var lbh1 = list.SelectWhere(GetIDName()+ "==" + a).FirstOrDefault();
            list.Update(lbh, lbh1);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public virtual ActionResult Delete(int id)
        {
            ModelController<m> list = GetController() as ModelController<m>;
            var a = RouteData.Values["id"];
            var lbh1 = list.SelectWhere(GetIDName() + "==" + a).FirstOrDefault();
            list.Delete(lbh1);
            return RedirectToAction("Index");
        }

        private object GetIDName()
        {
            m t = new m();
            if (t is LoaiBaiHoc)
                return "IdLBH";
            else if (t is BaiHoc)
                return "IdBaiHhoc";
            else if (t is BinhLuan)
                return "IdBinhLuan";
            else if (t is Images)
                return "IdHinh";
            else if (t is Like)
                return "IdUser";
            else
                return "IdUser";
        }
    }
}