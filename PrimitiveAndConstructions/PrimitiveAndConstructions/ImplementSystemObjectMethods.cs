using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public class ImplementSystemObjectMethods
    {
        public static void WriteMethods()
        {
            Console.WriteLine("***** Implement system object methods start *****");
            
            Console.WriteLine( "bool true string - " + bool.TrueString);
            
            Console.WriteLine("byte max value - " + byte.MaxValue);
            
            Console.WriteLine("int min value - " + int.MinValue);
            
            Console.WriteLine("char is number - " + char.IsNumber('C'));
            
            Console.WriteLine("***** Implement system object methods end ***** \n");
            
        }
    }
}