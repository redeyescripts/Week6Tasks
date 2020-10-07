using System;

namespace Week6Tasks3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; ++i)
                randomArray[i] = rnd.Next(1, 11);

            int biggest = randomArray[0];
            int smallest = randomArray[0];

            foreach (int value in randomArray)
            {
                if (value < smallest) smallest = value;
                if (value > biggest) biggest = value;
            }
            Console.WriteLine(randomArray[0]);
            Console.WriteLine(randomArray[1]);
            Console.WriteLine(randomArray[2]);
            Console.WriteLine(randomArray[3]);
            Console.WriteLine(randomArray[4]);
            Console.WriteLine(randomArray[5]);
            Console.WriteLine(randomArray[6]);
            Console.WriteLine(randomArray[7]);
            Console.WriteLine(randomArray[8]);
            Console.WriteLine(randomArray[9]);

            Console.WriteLine($"Smallest: {smallest}");
            Console.WriteLine($"Biggest: {biggest}");
        }
    }
}
