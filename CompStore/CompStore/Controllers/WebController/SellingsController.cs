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
using Microsoft.AspNet.Identity;

namespace CompStore.Controllers.WebController
{
    public class SellingsController : ApiController
    {
        DAOSelling dao = new DAOSelling();

        // GET: api/Sellings
        [HttpGet]
        public IEnumerable<Selling> GetSelling()
        {
            return dao.GetAllSelling();
        }


            //    // POST: api/Sellings
        [HttpPost]
        public Selling PostSelling(Selling selling)
        {
            var id_user = User.Identity.GetUserId();
            dao.AddSelling(id_user, selling);
            return selling;
        }

    }
}