using System;

namespace Test_Task
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lets find out if You are Lucky. To close the Program enter 'Exit'");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nEnter the Number that can be 4 to 8 digits long.");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\nNumber: ");
                try
                {
                    string str = Console.ReadLine();
                    if (str.ToLower() == "exit")
                        Environment.Exit(0);

                    if (str.Length < 4 || str.Length > 8)
                        throw new Exception("The number must be 4 to 8 digits long!");

                    if (str.Length % 2 == 1)
                        str = str.Insert(0, "0");

                    int n1 = 0, n2 = 0;
                    for (int i = 0; i < str.Length / 2; i++)
                    {
                        string nums = "0123456789";
                        if (!nums.Contains(str[i]) || !nums.Contains(str[i + str.Length / 2]))
                            throw new Exception("The number mustn't contain letters or digits!");

                        n1 += str[i];
                        n2 += str[i + str.Length / 2];
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(n1 == n2 ? "Your Ticket is Lucky!" : "Unfortunately. Try again.");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}