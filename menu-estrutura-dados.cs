using System;

namespace DataStructuresMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Data Structures Interactive Menu ===");
                Console.WriteLine("1. Arrays");
                Console.WriteLine("2. Matrices");
                Console.WriteLine("3. Work with List");
                Console.WriteLine("4. Work with Queue");
                Console.WriteLine("5. Work with Stack");
                Console.WriteLine("6. Search Algorithms");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ArrayMenu.Show();
                        break;
                    case "2":
                        MatrixMenu.Show();
                        break;
                    case "3":
                        ListMenu.Show();
                        break;
                    case "4":
                        QueueMenu.Show();
                        break;
                    case "5":
                        StackMenu.Show();
                        break;
                    case "6":
                        SearchAlgorithmsMenu.Show();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
