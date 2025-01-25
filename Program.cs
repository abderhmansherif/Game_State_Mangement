namespace Game_State_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Welcome to Game State Management");
            Console.WriteLine("pls enter your Name: ");
            string name = Console.ReadLine();

            var game = new Game(name);
            StateMangement StateMangement = new StateMangement(game);
            var history = new GameHistory(StateMangement);

            while (true)
            {
                Console.WriteLine("Please Enter Your Choise");
                Console.WriteLine("(1) Move Player (Up, Left, Right, Down)");
                Console.WriteLine("(2) Save");
                Console.WriteLine("(3) Undo");
                Console.WriteLine("(4) Show your current position and your Score");
                Console.WriteLine("(5) Show Your History");
                Console.WriteLine("(6) Exit");

                string choise = "";
                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        // Move Player
                        Console.Write("Enter Your Step (Up, Left, Right, Down): ");
                        string step = Console.ReadLine();
                        game.SetPlayer(step);
                        game.SetPoints(game.GetPoints() + 1);
                        Console.WriteLine($"The Player {name.ToLower()} Moved Seccussfully");
                        Console.WriteLine("---------------");
                        break;
                    case "2":
                        // Save
                        history.Backup();
                        Console.WriteLine("---------------");
                        break;
                    case "3":
                        // Undo
                        history.Undo();
                        Console.WriteLine("---------------");
                        break;
                    case "4":
                        Console.WriteLine("The Player Step: " + game.GetPlayer());
                        Console.WriteLine("The Player points: " + game.GetPoints());
                        Console.WriteLine("---------------");
                        break;
                    case "5":
                        // Show History
                        history.ShowHistory();
                        Console.WriteLine("---------------");
                        break;
                    case "6":
                        // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("---------------");
                        break;
                }
            }
        }
    }
}

