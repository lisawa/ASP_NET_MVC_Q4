using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_Q4.Models
{
    public class DeptModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SubDepartment> SubDepartments { get; set; }
    }
}