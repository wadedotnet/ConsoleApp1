﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            Class2 c2 = new Class2();
            Console.WriteLine($"Hello {c2.Name}! Is {c1.Date} now.");
            Console.ReadKey();
        }
    }
}
