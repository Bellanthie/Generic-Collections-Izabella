namespace Generic_Collections_Izabella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant Athena = new Restaurant();
            MenuItem GarlicBread = new MenuItem(1, "GarlicBread", 5);
            Athena.AddToMenu(GarlicBread);

        }
    }
}
