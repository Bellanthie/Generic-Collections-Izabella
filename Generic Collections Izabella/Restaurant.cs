using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Izabella
{
    public class Restaurant
    {
        List<MenuItem> Menu = new List<MenuItem>(); //deklarerat att vi skapar en ny lista 'från' List<menutien>
        Queue<Order> OrderList = new Queue<Order>();//samma här
        //private object orderQueue;
     
        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($" Maträtten {menuItem.Name} har lagts till i menyn");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Menu:");
            foreach(var item in Menu)
            {
                Console.WriteLine($"{item.ToString()}"); //item.ToString - gets the method used in menuItem
            }

            Console.WriteLine("-------------------------------------");
        }

        // Add order(s) to order list. QUEUE  function thingy
        public void CreateOrder(Order order)
        {
            OrderList.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.OrderId} ");

        }


        // I don't know how to make this yet.
        // Assuming we're using if-loop somehow, in case customer wants to cancel a specific order (although in real-time
        // this is rarely done since the customer needs to be super fast. 
        public void HandleOrder()
        {
            if (orderQueue.Count == 0)
            {
                Console.WriteLine("Det finns inga ordrar i kön ännu.");
                
            }
        }

        public void ShowOrder()
        {
            Console.WriteLine("~~~~Här är dina beställningar~~~~");
            // If there are no orders
        }

        public void ShowNextOrder()
        {
            Console.WriteLine("skriver ut beställningen som ´är näst i kön");
        }

        public void ShowOrderCount()
        {
            Console.WriteLine("skriver ut antalet beställningar i kön till konsolen");
        }




    }

}