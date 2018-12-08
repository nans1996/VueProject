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
using CompStore.Models.DAO;

namespace CompStore.Controllers.DAOController
{
    public class ProductsController : ApiController
    {
        DAOProduct dao = new DAOProduct();
        

        // GET: api/Products

        [HttpGet]
        public IEnumerable<Product> GetAllProduct()
        {
            return dao.GetAllProducts();
        }

        // GET: api/Products/5
        [HttpGet]
        public Product GetProduct(int id)
        {
            return dao.GetProduct(id);

        }

        // PUT: api/Products/5
        [HttpPut]
        public Product PutProduct(int id, Product product)
        {
            return dao.UpdateProduct(product, id);
        }

        // POST: api/Products
        //добавление
        
        [HttpPost]
        public Product PostProduct(Product product)
        {
            dao.AddProduct(product);
           return product;
        }

        // DELETE: api/Products/5
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            dao.DeleteProduct(id);
        }

       
    }
}