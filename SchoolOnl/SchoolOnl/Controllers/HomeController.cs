using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolOnl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }  
        public PartialViewResult KhoaDangHoc()
        {
            return PartialView();
        }
        public PartialViewResult KhoaChuaHoc()
        {
            return PartialView();
        }
        public PartialViewResult BaiVietHot()
        {
            return PartialView();
        }
        public PartialViewResult VideoHot()
        {
            return PartialView();
        }
        public ActionResult Hoc()
        {
            return View();
        }
        public ActionResult Hoi()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult HoiSingle()
        {
            return View();
        }
    }
}