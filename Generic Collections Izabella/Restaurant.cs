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

        }

    }

}