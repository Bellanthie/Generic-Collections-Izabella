using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Izabella
{
    public class Order
    {
        // Private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        // private Constructor below
        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Prehanded Auto IDs from the given assignment
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public int OrderId => _orderId;
        public int TableNumber => _tableNumber;
        public List<MenuItem> OrderItems => _orderItems;
        // Public read-only properties:
        // a variable(s) that can be accessed from outside the class, but its value can only be set once, 
        // typically during the object's creation in its constructor
        // So i set the data once and forEVER, and once initialized, that property cannot be changed.
        




        // Constructor is private (LOOK DOWN)
        // We have already created an object of Order.
        // a 'factory method' can return an already created object.

        public static Order Create(List<MenuItem> items, int tableNumber)
        {
            return new Order(items, tableNumber);
        }




        //Calculating the total price
        public decimal GetTotal()
        {
            decimal total = 0; 
            foreach (var item in _orderItems)
            {
                total += item.Price;
            }
            return total;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order {OrderId}:");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"1 st {item.Name} {item.Price:C} till bordsnummer {TableNumber}");
            }

            Console.WriteLine($"Summa: {GetTotal():0.00} kr");
            Console.WriteLine($"Till bordnummer {TableNumber}");
            // A blank line to separate this order from the next
            //PrintLine(); did not want to work. ill try with an empty CW
            Console.WriteLine();
        }
    }
}
