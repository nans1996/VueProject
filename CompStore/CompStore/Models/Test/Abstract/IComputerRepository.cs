using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompStore.Models.DAO;
using CompStore.Controllers;

namespace CompStore.Models.Test.Abstract
{
    public interface IComputerRepository
    {
        IEnumerable<Product> GetAllProduct();
    }
}