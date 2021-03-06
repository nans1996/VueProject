﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompStore.Models.DAO
{
    public class DAOCategory
    {

        public DAOCategory()
        {
            entities = new Entities();
            entities.Configuration.ProxyCreationEnabled = false;
        }

        private Entities entities;

        public IEnumerable<Category> GetAllCategoryes()
        {
            return entities.Category.Select(n => n);
          
        }
        public bool AddCategory(Category category)
        {
            try
            {
                entities.Category.Add(category);
                entities.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public Category UpdateCategory(int id, Category category)
        {
            var Entity = entities.Category.FirstOrDefault(x => x.Id == id);
            Entity.Name = category.Name;
            entities.SaveChanges();
            return Entity;
        }

        public Category GetCategory(int id)
        {
           

            return  entities.Category.Where(n => n.Id == id).First();
        }

        public List<Category> GetSearch(String searchString)
        {
            var categories = from category in entities.Category
                           select category;
            if (!String.IsNullOrEmpty(searchString))
            {
                categories = categories.Where(s => s.Name.ToUpper().Contains(searchString));
            }

            return categories.ToList();
        }

        public void DeleteCategory(int id)
        {
            Category orCat = GetCategory(id);
            entities.Category.Remove(orCat);
            entities.SaveChanges();

        }
    }
}