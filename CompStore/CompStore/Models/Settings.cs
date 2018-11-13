using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompStore.Models
{
    public class Settings
    {
        private static int id_shop = 4; // id магазина в системе

        public static int ID_shop
        {
            get
            {
                return id_shop;
            }
        }
    }
}