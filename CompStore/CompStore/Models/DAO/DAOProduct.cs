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


        StoreWebServiceSoapClient s = new StoreWebServiceSoapClient();
       private Entities entities;
        DAOCart cart = new DAOCart();

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

        public bool UpdateNumberProduct()
        {
            try
            {
                var c = cart.GetCart();
                foreach (var item in c)
                {
                    var Entity = entities.Product.FirstOrDefault(x => x.Id == item.id_product);
                    if (Entity.Number > item.Number)
                    {
                        Entity.Number = Entity.Number - item.Number;
                        entities.SaveChanges();
                    }
                    else
                    {
                        var pr = GetProduct(item.id_product);
                        DeletePresence(pr);
                        Entity.Number = 0;
                        Entity.Info = "нет в наличии" ;
                        entities.SaveChanges();
                    }

                }
            }
            catch
            {
                return false;
            }

            return true;
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

        public void AddToService(Product product)
        {
            try
            {
               
                s.AddReceive(Settings.ID_shop, product.Identificator, product.Number);
            }
            catch (System.ServiceModel.CommunicationException ex)
            {
                Logger.Log.Error("Ошибка: ", ex);
            }

        }

        public void DeletePresence(Product pr)
        {
            s.DeleteReceive(pr.Identificator, Settings.ID_shop);
        }
       
    }
}