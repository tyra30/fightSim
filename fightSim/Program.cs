using System;

namespace fightSim
{
    class Program
    {
        static void Main(string[] args)
        {
           Fighters avatar = new Fighters();

           avatar.name = ChooseName();
            Console.ReadLine();
        }
        static string ChooseName()
        {
        string name = "";
        Console.WriteLine("Welcome fighter, what is your name?");

        name = Console.ReadLine();

        Console.WriteLine($"Goodluck {name}");

        return name;
        }
    }
}
