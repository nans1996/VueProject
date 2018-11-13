using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompStore.Models.Test.Abstract;

namespace CompStore.Models.Test
{
    public class InMemoryComputerRepository: IComputerRepository
    {
        private List<Product> list = new List<Product>();
            public IEnumerable<Product> GetAllProduct()
        {
            return list;
        }
    }
}