﻿namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}\n");
                }
                Console.WriteLine("=============================\n");

            }
        }
    }
}
