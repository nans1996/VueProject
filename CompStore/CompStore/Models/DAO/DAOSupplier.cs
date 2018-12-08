using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompStore.Models.DAO
{
    public class DAOSupplier
    {
        public DAOSupplier()
        {
            entities = new Entities();
            entities.Configuration.ProxyCreationEnabled = false;
        }

        private Entities entities;

        public IEnumerable<Supplier> GetAllSupplier()
        {
            return entities.Supplier.Select(n => n);
        }

        public Supplier GetSupplier(int id)
        {
            return entities.Supplier.Where(n => n.Id == id).First();
        }

        public Supplier AddSupplier(Supplier supplier)
        {
            try
            {
                entities.Supplier.Add(supplier);
                entities.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                Logger.Log.Error("Ошибка: ", ex);

            }
            return supplier;
        }

        public Supplier UpdateSupplier(Supplier s, int id)
        {
            var Entity = entities.Supplier.FirstOrDefault(x => x.Id == id);
            Entity.Name = s.Name;
            Entity.Phone = s.Phone;
            Entity.Adress = s.Adress;
            entities.SaveChanges();
            return Entity;
        }
        public void DeleteSupplier(int id)
        {

            Supplier pr = GetSupplier(id);
            entities.Supplier.Remove(pr);
            entities.SaveChanges();

        }
    }
    }