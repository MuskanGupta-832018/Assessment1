using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    internal class PizzaCost
    {
        static void Main()
            {
                List<Pizza> pizzaOrders = new List<Pizza>();

                
                Pizza Mediumpizza1 = new Pizza(1, "Medium",5, 7);
                Pizza Mediumpizza2 = new Pizza(5, "Medium", 8, 1);

                pizzaOrders.Add(Mediumpizza1);
                pizzaOrders.Add(Mediumpizza2);

               
                foreach (Pizza pizza in pizzaOrders)
                {
                    Console.WriteLine(pizza.GetDescription());
                    Console.WriteLine("Cost: $" + pizza.CalcCost());
                   
                }
            }

        }
}
