using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using ASP_NET_MVC_Q4.Models;
using Newtonsoft.Json;

namespace ASP_NET_MVC_Q4.Repository
{
    public class SubDeptRepository
    {
        public List<SubDepartment> GetAll()
        {
            string json = string.Empty;

            using (StreamReader r = new StreamReader(HttpContext.Current.Server.MapPath("~/Models/sub_department.json")))
            {
                json = r.ReadToEnd();
            }

            var data = JsonConvert.DeserializeObject<List<SubDepartment>>(json);

            return data;
        }

        public List<SubDepartment> GetSubDeptByParentID(int pID)
        {
            var data = GetAll().Where(x => x.ParentId == pID).ToList();
            return data;
        }
    }
}