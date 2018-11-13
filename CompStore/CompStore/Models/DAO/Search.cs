using CompStore.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompStore.Models.DAO
{
    
    public class Search
    {
        Entities entities = new Entities();
        public CompStore.ServiceReference.ArrayOfString GetAllProductPresence(string id)
        {
            StoreWebServiceSoapClient s = new StoreWebServiceSoapClient();
           return s.GetAll(id,Settings.ID_shop);
        }
    }
}