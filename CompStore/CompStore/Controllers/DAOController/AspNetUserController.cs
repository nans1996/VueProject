using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompStore.Models.DAO;

namespace CompStore.Controllers.DAOController
{
    public class AspNetUserController : Controller
    {
        DAOAspNetUser daouser = new DAOAspNetUser();
       // GET: AspNetUser
        public ActionResult Index()
        {
            return View(daouser.GetAllUsers());
        }
        // GET: AspNetUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: AspNetUser/Edit/5
        public ActionResult Edit(string id)
        {
            AspNetUsers asp = daouser.GetUser(id);
            return View(asp);
        }
       
        // GET: AspNetUser/Delete/5
        public ActionResult Delete(string id)
        {
            return View("Delete", daouser.GetUser(id));
        }
        // POST: AspNetUser/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            if (id != null && ModelState.IsValid)
            {
                daouser.DeleteUser(id);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
   
    }
}
