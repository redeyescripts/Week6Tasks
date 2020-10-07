using System;

namespace Week6Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
             Random rnd = new Random();
            int[] numbers = new int[10];
           
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 11);
            }
            int sum = 0;

            foreach(int num in numbers)
            {
                sum = sum + num;
                Console.WriteLine(num);
            }
            Console.WriteLine($"Total: {sum}");
             
        }
    }
}
