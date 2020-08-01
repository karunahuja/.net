using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public string EmployeeProfile(int id)
        {
            string profile = string.Empty;
            if (id==1) 
            { 
                return "Profile 1"; 
            } if (id==2) 
            { 
                return "Profile 2"; 
            } if (id==3) 
            { 
                return "Profile 3"; 
            }
            else
            {
                return "No record found";
            }

           
        }
        public string Address(int id, int? code = null)
        {
            return "id=" + id + "dept=" + code;
        }
    }
}