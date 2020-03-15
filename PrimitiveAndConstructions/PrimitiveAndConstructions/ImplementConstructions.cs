using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public static class ImplementConstructions
    {

        private static int GetRundom(int maxVal)
        {
            Random gen = new Random();
            return  gen.Next(maxVal);
        }
        public static void WriteMethods()
        {
            Console.WriteLine("***** Implement constructions start *****");

            int num = GetRundom(100);
            
            if (num <= 50)
            {
                Console.WriteLine($"number {num} '<' or '=' 50");
            }else
            {
                Console.WriteLine($"number {num} '>' 50");
            }

            Console.WriteLine(num <= 10 ? $"number {num} '<' or '=' 10" : $"number {num} '>' 10");
            
            int num1 = GetRundom(3);
            switch (num1)
            {
                case 1:
                    Console.WriteLine($"switch number {num1} '=' 1");
                    break;
                case 2:
                    Console.WriteLine($"switch number {num1} '=' 2");
                    break;
                case 3:
                    Console.WriteLine($"switch number {num1} '=' 3");
                    break;
                default:
                    Console.WriteLine($"switch default number {num1} '=' 0");
                    break;
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            
            for (int i = 0; i <= numbers.Length; i++)
            {
                Console.WriteLine("for loop: {0}", i);
            }
            
            foreach (int item in numbers)
            {
                Console.WriteLine("foreach loop: {0}", item);
            }

            int b = 4;
            while (b > 0)
            {
                Console.WriteLine("while loop: {0}", b);
                b--;
            }
            
            int c = 3;
            do
            {
                Console.WriteLine("do while loop: {0}", c);
                c--;
            }
            while (c > 0);
            
            short a1 = 0;
            short b1 = 100;
            try
            {
                while (true)
                {
                    checked
                    {
                        a1++;
                    }
                    unchecked
                    {
                        b1++;
                    }
                }
            }
            catch
            {
                Console.WriteLine($"checked {a1}");
                Console.WriteLine($"unchecked {b1}");
            }
            
            
            Console.WriteLine("***** Implement constructions end ***** \n");
            
        }   
    }
}