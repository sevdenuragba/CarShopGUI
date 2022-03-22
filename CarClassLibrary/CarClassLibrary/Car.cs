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
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Not specified yet.";
            Model = "Not specified yet.";
            Price = 0.00M;
            Year = 0;
            Color = "Not specified yet.";
        }
    
        public Car(string a, string b, decimal c, int d, string e)
        {
            Make = a;
            Model = b;
            Price = c;
            Year = d;
            Color = e;
        }

        public override string ToString()
        {
            return "Brand: "+ Make+" "+ "Model: "+ Model+" "+ "Price: "+ Price+" " + "Year: "+ Year+" "+"Color: "+Color;
        }
    }   
}
