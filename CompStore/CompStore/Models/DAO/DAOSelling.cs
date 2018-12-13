using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using CompStore.ServiceReference;

namespace CompStore.Models.DAO
{
    public class DAOSelling
    {
        //StoreWebServiceSoapClient s = new StoreWebServiceSoapClient();
        Entities entities = new Entities();
        //DAOCart cart = new DAOCart();
        //DAOProduct product = new DAOProduct();


        public DAOSelling()
        {
            entities = new Entities();
            entities.Configuration.ProxyCreationEnabled = false;
        }


        public IEnumerable<Selling> GetAllSelling()
        {
            return entities.Selling.Select(n => n);
        }

        public Selling GetSelling(int id)
        {
            return entities.Selling.Where(n => n.Id == id).First();
        }

        //public IEnumerable<ProductList> GetSellingProduct(int id)
        //{

        //    return entities.ProductList.Where(n => n.Id_selling == id);
        //}

        //public Selling GetOneSelling(int id)
        //{
        //    return entities.Selling.Where(n => n.Id == id).First();
        //}
        //public bool AddProductList(int Id_sell)
        //{
        //    try
        //    {
        //        var c = cart.GetCart();
        //        foreach (var item in c)
        //            entities.ProductList.Add(new ProductList { Id_selling = Id_sell, Id_product = item.id_product, Number = item.Number });
        //        entities.SaveChanges();
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        //public bool UpdateNumberService()
        //{
        //    try
        //    { 
        //        var c = cart.GetCart();
        //        foreach (var item in c) {
        //           var pr = product.GetProduct(item.id_product);
        //            s.UpdateNumberProduct(item.Number, Settings.ID_shop, pr.Identificator);
        //        }
        //    }
        //    catch (System.ServiceModel.CommunicationException ex)
        //    {
        //        Logger.Log.Error("Ошибка: ", ex);
        //    }
        //    return true;
        //}

        public Selling AddSelling(string id_user, Selling sell)
        {
            
                var newsell = new Selling { Id_seller = id_user, Price = sell.Price, datetime = DateTime.Now, Status = sell.Status };
                entities.Selling.Add( newsell);
                entities.SaveChanges();

         
            return newsell;
        }

        //public Selling UpdateSelling(int id, Selling selling)
        //{
        //    var Entity = entities.Selling.FirstOrDefault(x => x.Id == id);
        //    Entity.Price = selling.Price;
        //    Entity.Status = selling.Status;
        //    entities.SaveChanges();
        //    return Entity;
        //}

        //public bool DeleteProductList(int id)
        //{
        //    try
        //    {
        //       var list = entities.ProductList.Where(n => n.Id_product == id);
        //        foreach (var item in list)
        //        {
        //            ProductList pr = item;
        //            entities.ProductList.Remove(pr);
        //            entities.SaveChanges();
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}