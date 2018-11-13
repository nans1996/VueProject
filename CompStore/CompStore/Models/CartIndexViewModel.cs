using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CompStore.Models.DAO;

namespace CompStore.Models
{
    public class CartIndexViewModel
    {
        public DAOCart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}