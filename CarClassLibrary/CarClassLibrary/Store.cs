using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingCart { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingCart = new List<Car>();

        }

        public decimal Checkout()
        {
            decimal TotalCost = 0.00M;
            foreach(var c in ShoppingCart)
            {
                TotalCost += c.Price;
            }
            ShoppingCart.Clear();
            return TotalCost;
        }
    }
}
