using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompStore.ServiceReference;
using CompStore.Models;
using System.Web.Mvc;

namespace CompStore.Models.DAO
{
    public class DAOProduct
    {
        public DAOProduct()
        {
            entities = new Entities();
            entities.Configuration.ProxyCreationEnabled = false;
        }


  
       private Entities entities;
     

        [HttpGet ]
        public IEnumerable<Product> GetAllProducts()
        {
            return entities.Product.Select(n => n);
        }

        public Product GetProduct(int id)
        {
            return entities.Product.Where(n => n.Id == id).First();
        }

        public Product AddProduct(Product product)
        {
            try
            {
                entities.Product.Add(product);
                entities.SaveChanges();
            }
            catch(System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                Logger.Log.Error("Ошибка: ", ex);
               
            }
            return product;
        }

       

        public Product UpdateProduct(Product p, int id)
        {
            var Entity = entities.Product.FirstOrDefault(x => x.Id == id);
            Entity.Identificator = p.Identificator;
            Entity.Name = p.Name;
            Entity.Id_category = p.Id_category;
            Entity.Id_supplier = p.Id_supplier;
            Entity.Number = p.Number;
            Entity.Price = p.Price;
            Entity.Country = p.Country;
            Entity.Accounting_date = p.Accounting_date;
            entities.SaveChanges();
            return Entity;
        }

        public void DeleteProduct(int id)
        {
            
                Product pr = GetProduct(id);
                entities.Product.Remove(pr);
                entities.SaveChanges();
           
        }

       
    }
}