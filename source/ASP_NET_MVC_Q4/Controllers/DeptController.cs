using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP_NET_MVC_Q4.Models;
using ASP_NET_MVC_Q4.Repository;

namespace ASP_NET_MVC_Q4.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dept()
        {
            var vm = new DeptViewModel();
            vm.Department = new DeptRepository().GetAll();
            vm.DeptList = new List<SelectListItem>();
            vm.Department.ForEach(x => vm.DeptList.Add(new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }));

            return View(vm);
        }

        public ActionResult GetDropDown(int id = 0)
        {
            return Json(new SubDeptRepository().GetSubDeptByParentID(id), JsonRequestBehavior.AllowGet);
        }
    }
}