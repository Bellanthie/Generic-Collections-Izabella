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

        }
    }
}