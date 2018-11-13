using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompStore.Models.DAO;
using CompStore.ServiceReference;

namespace CompStore.Controllers.DAOController
{
    public class SearchController : Controller
    {
        Search s = new Search();
        // GET: Search
        public ActionResult Index(String searchString)
        {
            List<string> list = new List<string>() { "" };
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(s.GetAllProductPresence(searchString));
            }         
            else return 
                    View(list);
        }
      
    }
}
