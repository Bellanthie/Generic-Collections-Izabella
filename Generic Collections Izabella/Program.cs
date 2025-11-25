namespace Generic_Collections_Izabella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Restaurant name/ object
            Console.WriteLine(" ____           _                                         _   _   _                      \r\n|  _ \\ ___  ___| |_ __ _ _   _ _ __ __ _ _ __   __ _     / \\ | |_| |__   ___ _ __   __ _ \r\n| |_) / _ \\/ __| __/ _` | | | | '__/ _` | '_ \\ / _` |   / _ \\| __| '_ \\ / _ \\ '_ \\ / _` |\r\n|  _ <  __/\\__ \\ || (_| | |_| | | | (_| | | | | (_| |  / ___ \\ |_| | | |  __/ | | | (_| |\r\n|_| \\_\\___||___/\\__\\__,_|\\__,_|_|  \\__,_|_| |_|\\__, | /_/   \\_\\__|_| |_|\\___|_| |_|\\__,_|\r\n                                               |___/                                     ");
            Console.WriteLine("                     .:-=*##%%%##*=-..                                                 \r\n              -                  -#@@@%%%%%%%%@@@@%=.                                               \r\n              *-                   :#@@@@@@@@@@@@%%@@*.                                             \r\n              =%.                   ..##+*#%#=++%@@@%%@:                                            \r\n              -**                     .+#%@@@#**%++@@%%@-                                           \r\n              :*#+                  .-*#%#**##@@%+@##@%%%.                                          \r\n              .*%#-               :**--..:-=++*#@@*%+%@%@-                                          \r\n              .*#*#:           .=#@###++=-:-=+*@#%@*@+@@@+                                          \r\n               **%*#.          :@%#*#%%*#***+*#@@*@+@+@@@=                                          \r\n               *+%@*=           .%+@@%#####%%@@@@*@*@*@@@:                                          \r\n               -*###.            #*#+:#@%%@%##@@@*#%*@@@*                                           \r\n                :#%#            .#:==.:@%@@@@%####..+@@@.          :##-+                            \r\n                 =%@-           ==:  :*@#%@%##%%@@=.:@@%       =*.-@*.                              \r\n                 :%*+           .-%: +@@#%@@@%%#%@@@=#@@+:.  .-*++@#.=***#-   :+-                   \r\n                  :#*.            +=.+%#%@@#%%%%%@--@*@@%%@%%%%#%%+-#*: .=@.  .=%                   \r\n                  :##-            :**=:@::+@*%%%##@*-++=*#@@@@@@*+%@=::.-#=.-*##::::.               \r\n                   *@+           ..    #  -#@##@@%#%%#%%#*#%##*@%######%+.=@*: .##=#%.              \r\n                   :#%::       ........#..=#@@*++**%@@%@@#*%#*%#@@@%#%@@@@##=-+@* %@@.              \r\n                   .%+**       ....-#%+..:#%*#+**+++*%@%#@##%#%#%@%####@####%%#++ ...               \r\n                  -+=**%.      ...*#++=+#*%*@*@**#%%%+*%%##%#%%%%%%###%#*#%@%%#%##%+.               \r\n                  -==++#-       :#=++**#@%%@%+-#-=**@@###%##%####%%#*#@%@***#*+-.-+=:               \r\n                  :*=@%@:      =%+++++@@%#@@*+*-+++*#%@@@#%%**##**++++-%@@+---=*@#=-#+              \r\n                   ##@#%.     -*:+*+-=#@*##@@**=*-+*#%@@@@*%@@%##*=-+#=.+%%%####:   .@.             \r\n                   =@@%%%:    =%%#:=+%@@*###%@@=*-**=:-@@@@@*%#%@@%@@=..   ... :=.:.+*              \r\n                   .+@@*%*-   .@%%#*@@@@**%#@@@@%=+#=::%@#@%%@+@@*#@@@@%#=..++ .#=....              \r\n                    .+@*@%=*.  :%%*@@@*#*@*%#%@@@+:..-%@@@%#@#%%*%%**#%@+-+#@%#*-.                  \r\n                     .+@#@*##-  -@@*++#%@*@%#@@@@@+-..+@@#%@*%%*#%##@#+++***+:.                     \r\n                       +*@%*+=*:+@#@#@@@@@#%@@@@%#@##+*#%%*#@%#@%*#%##%#*=+-++*+==.-.               \r\n                       .#%%@%:.*@@=*@##%%%%@@@@%:-%*==+=+*#+*%@#@@#**###+++-=+--::...               \r\n                        +*@@@%=.*@#=+*%@@@@@@@@=+*-+*@@@+@@%+*%@%%@@*++*%*#=:.:=--:                 \r\n                        :*@%@@%%*@@:#@@%*+**%%##*++@@#%*=@=@@=*@@@#%@@++=+##=*-.. .::               \r\n                         ##=+@@@@@@-*%@@@%--#@#%-+#*@@%:+%#=#%+*@@*#@@@@=+-+=@--*.                  \r\n                         =*#.-@@@#=*#@@+=%%=-++%-+%%=@@+++#@@@=+#@#++@@@@*-+-=-#=..                 \r\n                         .*%: .:.  #@*=%#-=+++*%++#%%%%@+++*@@=++@-:#+*@@===--=::=:                 \r\n                          +=-      ==-#=.-=-+=++#:.**++**====#.-+#. --=-#- :-:.                     \r\n                                                                                  ");
            Restaurant Athena = new Restaurant(); //object

            // SHOW MENU BLOCK OF CODE
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
            Athena.PrintLine();


            Athena.ShowMenu();
              
            Queue<Order> OrderList = new Queue<Order>(); //copied this here from the restaurant class to see what is affected
            Order order1 = new Order(new List<MenuItem> { GarlicBread, Bolognese }, 4);
            Order order2 = new Order(new List<MenuItem> { Bolognese, GarlicBread, JanssonsFrestelse }, 22);
            Order order3 = new Order(new List<MenuItem> { Mousaka, GarlicBread }, 15);

            Athena.PrintLine();

            //Order kön
            Athena.CreateOrder(order1);
            Athena.CreateOrder(order2);
            Athena.CreateOrder(order3); // all orders aren't necessary to include. i could just include order 2 and 3. We understand the overall idea
            Athena.PrintLine();

            // Active Orders
            Console.WriteLine("Aktuella Ordrar");
            Athena.ShowOrders();

            // Orders in queue
            Athena.ShowOrderCount();

            // Shows next order in queue
            Athena.ShowNextOrder();

            // Handle Order
            Athena.HandleOrder();
            Console.ReadLine();
            
        }
    }
}