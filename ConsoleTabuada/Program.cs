using System;

namespace ConsoleTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Insira um número:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                result = num * i;
                Console.WriteLine(num + " x " + i + " = " + result);
            }
        }
    }
}
