using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Car Shop. You can add a car to the inverntory or you can add cars to your shopping cart. Also you can see the total cost of your shopping cart. ");

            Store s = new Store();
            int action = chooseAction();
            while (action!=0)
            {
                Console.WriteLine("You chose:"+ action);
                switch (action)
                {
                    case 1:
                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = -1;
                        int carYear = 0;
                        string carColor = ""; 
                        Console.WriteLine("Enter the car brand.");
                        carMake = Console.ReadLine();
                        Console.WriteLine("Enter the car model.");
                        carModel = Console.ReadLine();

                        while (carPrice == -1)
                        {
                            carPrice = getPriceFromInput();
                        }
                       
                       
                        Console.WriteLine("Enter the year of the car.");
                        carYear = int.Parse(Console.ReadLine());
                       
                        Console.WriteLine("Enter the color.");
                        carColor = Console.ReadLine();
                        Car newCar = new Car(carMake,carModel,carPrice,carYear,carColor);
                        s.CarList.Add(newCar);
                        printInventory(s);
                        action = chooseAction();
                        break;

                    case 2:
                        printInventory(s);
                        Console.WriteLine("Choose the number of the car that you want to your shopping cart.");
                        int carChosen = int.Parse(Console.ReadLine());
                        s.ShoppingCart.Add(s.CarList[carChosen]);
                        printShoppingCart(s);
                        action = chooseAction();
                        break;

                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine("The total cost: " + s.Checkout());
                        action = chooseAction();
                        break;

                    default:
                        break;
                }
                
            }
        
        
        }

        public static decimal getPriceFromInput()
        {
            try
            {
                Console.WriteLine("Enter the price.");
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You made an invalid entry. Please try again.");
                return -1;
            }
            return -1;
        }

        public static void printShoppingCart(Store s)
        {
            Console.WriteLine("Your shopping cart:");
            for (int i = 0; i < s.ShoppingCart.Count; i++)
            {
                Console.WriteLine("-Car " + i + "- " + s.ShoppingCart[i]);
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit, (1) to add a car to inventory, (2) to add a car to shopping cart, (3) to show the total cost...");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static public void printInventory(Store s)
        {
            for(int i =0 ; i < s.CarList.Count ; i++)
            {
                Console.WriteLine("-Car "+i+"- "+ s.CarList[i]);
            }
        }
}
}
