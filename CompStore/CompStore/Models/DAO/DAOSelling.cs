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
  
        Entities entities = new Entities();
  


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

       

        public Selling AddSelling(string id_user, Selling sell)
        {
            
                var newsell = new Selling { Id_seller = id_user, Price = sell.Price, datetime = DateTime.Now, Status = sell.Status };
                entities.Selling.Add( newsell);
                entities.SaveChanges();

         
            return newsell;
        }

       
    }
}