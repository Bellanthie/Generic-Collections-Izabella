namespace Generic_Collections_Izabella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Restaurant name/ object
            Console.WriteLine("Välkommen till Restaurang Athena!");
            Restaurant Athena = new Restaurant(); //object

            // Different objects of menu items
            MenuItem GarlicBread = new MenuItem(1, "GarlicBread -", 65);
            Athena.AddToMenu(GarlicBread);

            // Bolognese item object added
            MenuItem Bolognese = new MenuItem(2, "Bolognese -", 169);
            Athena.AddToMenu(Bolognese);

            MenuItem Mousaka = new MenuItem(3, "Mousaka -", 229);
            Athena.AddToMenu(Mousaka);

            MenuItem JanssonsFrestelse = new MenuItem(4, "Janssons Frestelse -", 229);
            Athena.AddToMenu(JanssonsFrestelse);


            Athena.ShowMenu();
              
            Queue<Order> OrderList = new Queue<Order>(); //copied this here from the restaurant class to see what is affected
            Console.WriteLine("---------------------------------------------------"); // i wanted to create a breakline between the menu and the orders list
            Order order1 = new Order([GarlicBread, Bolognese],4);
            Order order2 = new Order([Bolognese, GarlicBread, JanssonsFrestelse], 22);
            Order order3 = new Order([Mousaka, GarlicBread], 15);

            Athena.CreateOrder(order1);
            Athena.CreateOrder(order2);
            Athena.CreateOrder(order3); // all orders aren't necessary to include. i could just include order 2 and 3. We understand the overall idea
            Console.ReadKey();

            // Method to show real-time orders
            Athena.ShowOrder(Order.OrderList);




        }
    }
}