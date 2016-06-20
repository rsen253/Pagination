using Paging.DataAccessLayer;
using Paging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Paging.Controllers
{
    public class EmployeeController : Controller
    {
        private DataAccessContext dbcontext = new DataAccessContext();
        // GET: Employee
        //public ActionResult Index2(int? page)
        //{
        //    const int pageSize = 5;
        //    int PageNumber = (page ?? 1);

        //    var result = dbcontext.Employee.ToList();
        //    return View(result.ToPagedList(PageNumber, pageSize));
        //}

        public ActionResult Index(int? page)
        {
            const int pageSize = 5; //Number of item in one page
            int pageNumber = (page ?? 1); //Page Current
            var list = new EmployeeViewModel()
            {
                EmployeeList = dbcontext.Employee.ToList()
            };
            return View(list.EmployeeList.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            dbcontext.Employee.Add(emp);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}