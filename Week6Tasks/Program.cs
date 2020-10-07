
using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };
           
            Console.WriteLine("Tell your items (15)");
            
            int i = 0;
            while (i > superHeroes.Length)
            {
                Console.WriteLine("Tell your items");
                superHeroes[i] = Console.ReadLine();
                i++;
            }
            Random rnd = new Random();
            Console.WriteLine($"fight with zombies using " + $"{superHeroes[rnd.Next(0, superHeroes.Length)]}", $"{superVillains[rnd.Next(0, superVillains.Length)]}", $"{ weapon[rnd.Next(0, weapon.Length)]}");

        }
    }
}
