using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Izabella
{
    internal class MenuItem
    {

        // { get; set;} allows acces to both the computer and myself. The pc can look into the box and see the value GET; --
        // while the user is given permission to change the value of the property OR put something new into the object SET;
        // Predefined properties/attributes for menuItem class
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public decimal Price { get; set; } = 0;

        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }


        public override string ToString()
        {
            return $"{Id} - {Name} - {Price:C}.";
        }


    }
}
