using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using ASP_NET_MVC_Q4.Models;
using Newtonsoft.Json;

namespace ASP_NET_MVC_Q4.Repository
{
    public class DeptRepository
    {
        public List<Department> GetAll()
        {
            string json = string.Empty;

            using (StreamReader r = new StreamReader(HttpContext.Current.Server.MapPath("~/Models/department.json")))
            {
                json = r.ReadToEnd();
            }

            return JsonConvert.DeserializeObject<List<Department>>(json);
        }
    }
}