using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient; 


namespace MVC_AJAX_ConnectionDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/

        DBManager dm = new DBManager();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InsertRecord(string n, string c)
        {
            string q = "insert into tbl_testdb values('" + n + "','" + c + "')";
            bool res = dm.InsertUpdateDelete(q);
            string confirm;
            if (res == true)
            {
                confirm = "success";
            }
            else
            {
                confirm = "failure";
            }

            return Json(confirm, JsonRequestBehavior.AllowGet);
        }


    }
}
