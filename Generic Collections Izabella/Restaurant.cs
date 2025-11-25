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
        public Queue<Order> OrderList = new Queue<Order>();//samma här
        private object _orderId;
        private object _tableNumber;

        //private object orderQueue;

        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($" Maträtten {menuItem.Name} har lagts till i menyn");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var item in Menu)
            {
                Console.WriteLine($"{item.ToString()}"); //item.ToString - gets the method used in menuItem
            }
        }

        // Add order(s) to order list. QUEUE  function thingy
        public void CreateOrder(Order order)
        {
            OrderList.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.OrderId} har lagts till.");

        }


        // I don't know how to make this yet.
        // Assuming we're using if-loop somehow, in case customer wants to cancel a specific order (although in real-time
        // this is rarely done since the customer needs to be super fast. 
        // What is the purpose of HandleORDER? I dont understand how we are supposed to Handle an order?
        public void HandleOrder()
        {
            // We needed some sort of de-queue here. Now im tired..
            if (OrderList.Count == 0)
            {
                Console.WriteLine("Det finns inga ordrar i kön ännu.");
                return;
            }
            Order finished = OrderList.Dequeue();
            Console.WriteLine($"order {finished.TableNumber} är färdig");
            Console.WriteLine();
        }

        public void ShowOrders()
        {
            Console.WriteLine($"Beställning #{_orderId} - Bord {_tableNumber}");
            // If there are no orders
            if (OrderList.Count == 0)
            {
                Console.WriteLine("Det finns inga aktuella beställningar");
                return;
            }
            foreach (Order order in OrderList)
            {
                order.PrintOrder();
            }
        }

        public void ShowNextOrder()
        {
            if (OrderList.Count == 0)
            {
                Console.WriteLine("Inga beställningar väntar");
                return;
            }
            Console.WriteLine("Nästa beställning i kön:");
            Order nextOrder = OrderList.Peek();
            nextOrder.PrintOrder();
        }

        public void ShowOrderCount()
        {
            Console.WriteLine($"Antal beställningar i kön: {OrderList.Count}");
        }

        public void PrintLine()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}