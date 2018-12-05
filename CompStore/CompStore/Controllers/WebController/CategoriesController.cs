using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CompStore.Models.DAO;

namespace CompStore.Controllers.WebController
{
    public class CategoriesController : ApiController
    {

        DAOCategory daocat = new DAOCategory();

        // GET: Category
        [HttpGet]
        public IEnumerable<Category> GetAllCategory()
        {
            return daocat.GetAllCategoryes();
        }

        [HttpGet]
        public List<Category> GetSearch(String searchString)
        {
            return daocat.GetSearch(searchString);
        }

        // GET: Category/Details/5
        [HttpGet]
        public Category GetCategory(int id)
        {
            return daocat.GetCategory(id);
        }

        // POST: Category/Create
        [HttpPost]
        public Category PostCategory( Category category)
        {
            daocat.AddCategory(category);
            return category;
        }
        // GET: Category/Edit/5
        [HttpPut]
        public Category PutEdit(int id, Category category)
        {
           
                
         Category c =   daocat.UpdateCategory(id, category);
            return c;
        }
        
        // GET: Category/Delete/5
        public void Delete(int id)
        {
            daocat.DeleteCategory(id);
        }
       
    }
}

