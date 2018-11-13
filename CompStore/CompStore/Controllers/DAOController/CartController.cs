using CompStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompStore.Models;
using CompStore.Models.DAO;


namespace CompStore.Controllers.DAOController
{
    public class CartController : Controller
    {
        DAOProduct daop = new DAOProduct();
        Entities entities = new Entities();
        DAOCart cart = new DAOCart();

        public ActionResult Index()
        {
            var c = cart.GetCart();
            return View(c);
        }
        public EmptyResult AddToCart(int id)
        {
            var pr = daop.GetProduct(id);
            cart.AddItem(pr);
            return new EmptyResult();
        }
        public ActionResult Delete(int id)
        {
            cart.DeleteCart(id);
            var c = cart.GetCart();
            return View("Index",c);
        }

        public ActionResult DeleteAll()
        {
            cart.RemoveAll();
            var c = cart.GetCart();
            return View("Index", c);
        }
           }

    }
