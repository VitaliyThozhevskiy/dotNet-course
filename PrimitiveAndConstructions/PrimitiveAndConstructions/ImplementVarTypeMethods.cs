using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public static class ImplementVarTypeMethods
    {
        
        public static int ReturnValue()
        {
            var a = 5;
            int b = 5;

            return a + b;
        }
        
        public static void WriteMethods()
        {
            Console.WriteLine("***** Implement var type methods start *****");
            // 1
            var codes = new List<int> { 1, 2, 7, 9 };
            Console.WriteLine("list count: " + codes.Count);
            
            // 2
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (var item in numbers)
            {
                Console.WriteLine("var loop: {0}", item);
            }
            
            // 3
            Console.WriteLine("return value: {0}", ReturnValue().ToString());
            
            // 4
            var data = new Dictionary<string, int>();
            data.Add("cat", 2);
            data.Add("dog", 1);
            Console.WriteLine("cat - dog = {0}", data["cat"] - data["dog"]);

            //5
            string firstName = "Steven";
            var lastName = "Clark";
            Console.WriteLine($"full name - {firstName} {lastName}");
            
            Console.WriteLine("***** Implement var type methods end ***** \n");
            
        }
    }
}