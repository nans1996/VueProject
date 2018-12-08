using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CompStore.Models.DAO
{
    public class DAOAspNetUser
    {
        public DAOAspNetUser() {
         entities = new Entities();
        entities.Configuration.ProxyCreationEnabled = false;

     }

        private Entities entities;

    public IEnumerable<AspNetUsers> GetAllUsers()
        {
            return entities.AspNetUsers.Select(n => n);
        }
             
        public AspNetUsers UpdateUser(AspNetUsers user, string id)
        {
                var Entity = entities.AspNetUsers.FirstOrDefault(x => x.Id == id);
                Entity.Email = user.Email;
                Entity.Name = user.Name;
                Entity.n_per_file = user.n_per_file;
                Entity.Salary = Entity.Salary;
                entities.SaveChanges();
            return user;
          
        }

        public AspNetUsers GetUser(string id)
        {
            return entities.AspNetUsers.Where(n => n.Id == id).First();
        }

        public bool DeleteUser(string id)
        {
            try
            {
                AspNetUsers or = GetUser(id);
                entities.AspNetUsers.Remove(or);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

    }
}