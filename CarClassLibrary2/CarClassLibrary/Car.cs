using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }


        public Car()
        {
            Make = "Not specified yet.";
            Model = "Not specified yet.";
            Price = 0.00M;

        }

        public Car(string a, string b, decimal c)
        {
            Make = a;
            Model = b;
            Price = c;

        }

        public override string ToString()
        {
            return "Brand: " + Make + " " + "Model: " + Model + " " + "Price: " + Price;
        }

     
    
    }   
}
