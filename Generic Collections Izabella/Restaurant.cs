using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Izabella
{
    internal class Restaurant
    {
        List<MenuItem> Menu = new List<MenuItem>(); //deklarerat att vi skapar en ny lista 'från' List<menutien>
        Queue<Order> OrderList = new Queue<Order>();//samma här
     
        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} was added to your list");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Menu:");
            foreach(var item in Menu)
            {
                Console.WriteLine($"{item.ToString()}"); //item.ToString - gets the method used in menuitem
            }

            Console.WriteLine("-------------------------------------");
        }

        public void CreateOrder(Order order)
        {
            

        }


        public void HandleOrder()
        {
            Console.WriteLine("Hanterar /tar bort den första beställningen i ön och loggar dtta till konsolen ");
        }

        public void ShowOrder()
        {
            Console.WriteLine("Skriver ut alla beställningar i kön til konsolen");
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