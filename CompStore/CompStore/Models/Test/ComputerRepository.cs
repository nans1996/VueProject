using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompStore.Models.Test.Abstract;

namespace CompStore.Models.Test
{
    public class ComputerRepository: IComputerRepository
    {
        private Entities entities = new Entities();
        public IEnumerable<Product> GetAllProduct()
        {
            return entities.Product.ToList();
        }
    }
}