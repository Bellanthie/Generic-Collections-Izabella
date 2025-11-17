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
            MenuItem GarlicBread = new MenuItem(1, "GarlicBread", 5);
            Athena.AddToMenu(GarlicBread);

            MenuItem Bolognese = new MenuItem(2, "Bolognese", 15);
            Athena.AddToMenu(Bolognese);

            MenuItem Mousaka = new MenuItem(3, "Mousaka", 30);
            Athena.AddToMenu(Mousaka);

            MenuItem JanssonsFrestelse = new MenuItem(4, "Janssons Frestelse", 30);
            Athena.AddToMenu(JanssonsFrestelse);


            Athena.ShowMenu();

        }
    }
}