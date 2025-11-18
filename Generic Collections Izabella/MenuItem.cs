using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Izabella
{
    internal class MenuItem
    {

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
