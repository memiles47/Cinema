using System;
using System.Collections.Generic;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var films = new Dictionary<string, List<int>>()
            {
                {"finding dory", new List<int>() { 3, 5 } },
                {"bourne", new List<int>() { 18, 5 } },
                {"tarzan", new List<int>() {15,5 } },
                {"ghost busters", new List<int>() {12,5 } }
            };

            while (true)
            {
                Console.Write("What film would you like to watch?: ");
                var choice = Console.ReadLine().ToLower();

                if (films.ContainsKey(choice))
                {
                    Console.Write("How old are you?: ");
                    var age = Convert.ToInt32(Console.ReadLine());

                    if (age >= films[choice][0])
                    {
                        if (films[choice][1] > 0)
                        {
                            Console.WriteLine("Enjoy the film!");
                            films[choice][1] -= 1;
                        }
                        else
                            Console.WriteLine("Sorry we are sold out!");
                    }
                    else
                        Console.WriteLine("You are too young to see that film!");
                }
                else
                    Console.WriteLine("We don't have that film...");
            }
        }
    }
}
