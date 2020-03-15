using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public static class CastingTipes
    {
        // Implicit Casting (automatically) - converting a smaller type to a larger type size
        // char -> int -> long -> float -> double

        private static Dictionary<string, dynamic> ImplicitCasting()
        {
            Dictionary<string, dynamic> _primitivs = new Dictionary<string, dynamic>();
            
            char myChar = '9';
            _primitivs.Add(myChar.GetType().ToString(), myChar);

            int myInt = myChar;
            _primitivs.Add(myInt.GetType().ToString(), myInt);
            
            long myLong = myInt;
            _primitivs.Add(myLong.GetType().ToString(), myLong);
            
            float myFloat = myLong;
            _primitivs.Add(myFloat.GetType().ToString(), myFloat);
            
            double myDouble = myFloat;
            _primitivs.Add(myDouble.GetType().ToString(), myDouble);
            
            return _primitivs;
        }
        
        // Explicit Casting (manually) - converting a larger type to a smaller size type
        // double -> float -> long -> int -> char
        private static Dictionary<string, dynamic> ExplicitCasting()
        {
            Dictionary<string, dynamic> _primitivs = new Dictionary<string, dynamic>();
            
            double myDouble = 100.0;
            _primitivs.Add(myDouble.GetType().ToString(), myDouble);

            float myFloat = (float) myDouble;
            _primitivs.Add(myFloat.GetType().ToString(), myFloat);

            long myLong = (long) myFloat;
            _primitivs.Add(myLong.GetType().ToString(), myLong);
            
            int myInt = (int) myLong;
            _primitivs.Add(myInt.GetType().ToString(), myInt);

            char myChar = (char) myInt;
            _primitivs.Add(myChar.GetType().ToString(), myChar);

            return _primitivs;
        }
        
        public static void WritePrimitive()
        {
            Console.WriteLine("***** Casting types start ***** \n");
            Console.WriteLine("***** Implicit Casting ***** \n");
            
            foreach (KeyValuePair<string, dynamic> keyValue in ImplicitCasting())
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
            Console.WriteLine(" \n ***** Explicit Casting ***** \n");
            
            foreach (KeyValuePair<string, dynamic> keyValue in ExplicitCasting())
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
            Console.WriteLine("***** Casting types end ***** \n");
            
        }
    }
}