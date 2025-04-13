// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

class Program
{
    static List<string> Names = new List<string> { "Jake" };
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("(1 - View all) (2 - Add Friend) (3 - Remove Friend) (4 - Exit)");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                for (int i = 0; i < Names.Count; i++)
                {
                    Console.WriteLine(i + " " + Names[i]);
                    Console.WriteLine("Press any key to Continue");
                    Console.ReadKey();

                }
            }
            else if (selection == "2")
            {
                Console.WriteLine("Add Friend's Name:");
                string newfriend = Console.ReadLine();
                Names.Add(newfriend);
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else if (selection == "3")
            {
                Console.WriteLine("Type the name you want to remove:");
                string friendToRemove = Console.ReadLine();
                if (Names.Contains(friendToRemove))
                {
                    Names.Remove(friendToRemove);
                }
                else
                {
                    Console.WriteLine("Friend not found.");
                }
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else if (selection == "4")
            {
                break;
            }
        }
    }
}
