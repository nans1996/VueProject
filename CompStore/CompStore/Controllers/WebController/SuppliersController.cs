using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CompStore;
using CompStore.Models.DAO;

namespace CompStore.Controllers.WebController
{
    public class SuppliersController : ApiController
    {
        DAOSupplier dao = new DAOSupplier();

        // GET: api/Suppliers
        [HttpGet]
        public IEnumerable<Supplier> GetSupplier()
        {
            return dao.GetAllSupplier();
        }

        // GET: api/Suppliers/5
        
        public Supplier GetSupplier(int id)
        {
            return dao.GetSupplier(id);
        }

        // PUT: api/Suppliers/5
        [HttpPut]
        public Supplier PutSupplier(int id, Supplier supplier)
        {
            Supplier s = dao.UpdateSupplier(supplier, id);
            return s;
        }

        // POST: api/Suppliers
        [HttpPost]
        public Supplier PostSupplier(Supplier supplier)
        {
            dao.AddSupplier(supplier);
            return supplier;
        }

        // DELETE: api/Suppliers/5
        [HttpDelete]
        public void DeleteSupplier(int id)
        {
            dao.DeleteSupplier(id);
        }

       

    }
}