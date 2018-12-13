using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompStore.Models.DAO;
using PagedList;
using Microsoft.AspNet.Identity;

namespace CompStore.Controllers.DAOController
{
    public class SellingController : Controller
    {
        Entities entities = new Entities();
        DAOSelling s = new DAOSelling();
        DAOCart cart = new DAOCart();
        DAOProduct product = new DAOProduct();
        Selling sell = new Selling();


        // GET: Product
        public ActionResult Index(int? page)
        {
            var model = entities.Selling.ToList();
            int pageNumber = page ?? 1;
            int pageSize = 10;
            return View(model.ToPagedList(pageNumber, pageSize));
        }
        //public ActionResult IndexSellingProduct(int id)
        //{
          
        //    return View(s.GetSellingProduct(id));
        //}

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(s.GetSelling(id));
        }
        // GET: Product/Create
        public ActionResult Create()
        {
            var summ = cart.ComputeTotalValue();
            sell.Price = summ;

            return View(sell);
        }

        // POST: Product/Create
        //[HttpPost]
        //public ActionResult Create([Bind(Exclude = "Id")] Selling selling)
        //{
        //    var id_user = User.Identity.GetUserId();
            
        //    if (s.AddSelling(id_user, selling) && product.UpdateNumberProduct())
        //    {
        //            cart.RemoveAll();
        //            return RedirectToAction("Index");
        //    }
        //    else
        //    {

        //        return View("Create");
        //    }
        //}
    }
}
