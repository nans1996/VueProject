﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompStore.Models.DAO;
using PagedList;
using CompStore.Models.Test.Abstract;
using CompStore.ServiceReference;
using CompStore.Models;

namespace CompStore.Controllers.DAOController
{
    public class ProductController : Controller
    {

        public ProductController()
        {
            entities = new Entities();
            entities.Configuration.ProxyCreationEnabled = false;
        }

        private Entities entities;

        DAOProduct DaoP = new DAOProduct();
        DAOCategory category = new DAOCategory();
        DAOSupplier sup = new DAOSupplier();
        IComputerRepository comp;

        public bool ViewDataSelectList(int c_id)
        {
            var categoryes = category.GetAllCategoryes();
            ViewData["CategoryId"] = new SelectList(categoryes, "Id", "Name", c_id);
            return (categoryes.Count() > 0);
        }
        // GET: Product

        public ActionResult Index(String searchString)
        {
            var products = from product in entities.Product
                           select product;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.ToUpper().Contains(searchString) || s.Identificator.ToUpper().Contains(searchString));
            }

            return View(products.ToList());
        }

        //[HttpPut]
        //     public IEnumerable<Product> Index()
        // {
        //     return DaoP.GetAllProducts();
        // }
        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(DaoP.GetProduct(id));
        }

        public ActionResult Primer(int id)
        {
            return View(DaoP.GetProduct(id));
        }
        // GET: Product/Create
        public ActionResult Create()
        {

            var categoryes = category.GetAllCategoryes();
            ViewData["CategoryId"] = new SelectList(categoryes, "Id", "Name");
            ViewData["Category"] = category.GetAllCategoryes();

            var supllier = sup.GetAllSupplier();
            ViewData["SupplierId"] = new SelectList(supllier, "Id", "Name");
            ViewData["Supplier"] = sup.GetAllSupplier();
            return View("Create");
        }
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Product product)
        {
            //if (DaoP.AddProduct(product))
            //{
                DaoP.AddToService(product);
                return RedirectToAction("Index");
            //}
            //else
            //{

            //    return HttpNotFound();
            //}
        }
        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var categoryes = category.GetAllCategoryes();
            ViewData["CategoryId"] = new SelectList(categoryes, "Id", "Name");
            ViewData["Category"] = category.GetAllCategoryes();

            var supllier = sup.GetAllSupplier();
            ViewData["SupplierId"] = new SelectList(supllier, "Id", "Name");
            ViewData["Supplier"] = sup.GetAllSupplier();

            Product pr = DaoP.GetProduct(id);
            if (!ViewDataSelectList(pr.Category.Id))
                return RedirectToAction("Index");
            return View(pr);
        }
        //// POST: Product/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, Product contact)
        //{
        //    if ((id > 0) && (contact != null) && (ModelState.IsValid))
        //    {
        //        DaoP.UpdateProduct(contact);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {

        //        return HttpNotFound();
        //    }
        //}
        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var pr = DaoP.GetProduct(id);
            DaoP.DeletePresence(pr);
            return View("Delete", DaoP.GetProduct(id));
        }
        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if (id > 0 && ModelState.IsValid)
            {
                //DaoP.DeletePresence(id);
                DaoP.DeleteProduct(id);
                return RedirectToAction("Index");
            }

            else
                return View();
        }
    }
}
