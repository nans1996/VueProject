using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompStore.Models.DAO
{
    public class DAOCart
    {
        private Entities entities = new Entities();

        public IEnumerable<Cart> GetCart()
        {
            return entities.Cart.Select(n => n);
        }
           
        public bool AddItem(Product product)
        {
            try
            {
                var c = entities.Cart.FirstOrDefault(p => p.id_product == product.Id);
                if ((c != null)&& (c.Number < product.Number))
                {
                    c.Number++;
                    entities.SaveChanges();
                }
                else 
                {
                    Cart cart = new Cart();
                    cart.id_product = product.Id;
                    cart.Number = 1;
                    cart.Price = product.Price;
                    entities.Cart.Add(cart);
                    entities.SaveChanges();
                }  

            }
            catch
            {
                return false;
            }
            return true;
        }
      
        public Cart GetCart(int id)
        {
            return entities.Cart.Where(n => n.id_product == id).First();
        }

        public void DeleteCart(int id)
        {
            Cart Cat = GetCart(id);
            if (Cat.Number > 1)
            {
                Cat.Number--;
                entities.SaveChanges();
            }
            else { 
                entities.Cart.Remove(Cat);
                entities.SaveChanges();
            }

        }

        public decimal ComputeTotalValue()
        {
            var sum = entities.Cart.Sum(e => e.Price * e.Number);
            if (sum != 0)
                return sum;
            else return 0;
        }

        public void RemoveAll()
        {
            entities.Cart.RemoveRange(entities.Cart);
            entities.SaveChanges(); 
        }

    }
}
