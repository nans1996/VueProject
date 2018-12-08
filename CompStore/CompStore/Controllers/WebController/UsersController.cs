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
    public class UsersController : ApiController
    {
        DAOAspNetUser dao = new DAOAspNetUser();

        // GET: api/Users
        [HttpGet]
        public IEnumerable<AspNetUsers> GetAspNetUsers()
        {
            return dao.GetAllUsers();
        }

        // GET: api/Users/5
        [HttpGet]
        public AspNetUsers GetAspNetUsers(string id)
        {
           return dao.GetUser(id);
        }

        // PUT: api/Users/5
        [HttpPut]
        public AspNetUsers PutAspNetUsers( AspNetUsers aspNetUsers, string id)
        {
            return dao.UpdateUser(aspNetUsers, id);
           
        }

        // DELETE: api/Users/5
        [HttpDelete]
        public void DeleteAspNetUsers(string id)
        {
            dao.DeleteUser(id);
        }

        
    }
}