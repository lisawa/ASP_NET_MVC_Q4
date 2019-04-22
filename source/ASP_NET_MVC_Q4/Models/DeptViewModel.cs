using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q4.Models
{
    public class DeptViewModel
    {
        public List<Department> Department { get; set; }

        public List<SelectListItem> DeptList { get; set; }
    }
}