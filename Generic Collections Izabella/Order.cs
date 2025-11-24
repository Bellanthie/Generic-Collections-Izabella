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

        // Constructor below
        private Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Prehanded Auto IDs from the given assignment
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
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
            Console.WriteLine($"Order {_orderId}:");
            foreach (var item in _orderItems)
            {
                Console.WriteLine($"1 st {item.Name} {item.Price:C} till bordsnummer {_tableNumber}");
            }

            Console.WriteLine($"Summa: {calculateTotal():0.00 kr}");
        }


    }
}
