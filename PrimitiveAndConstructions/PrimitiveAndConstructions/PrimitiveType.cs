using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public class PrimitiveType
    {
       private readonly Dictionary<string, dynamic> _dictionary = new Dictionary<string, dynamic>();

       public PrimitiveType()
       {
           bool myBool = true;
           _dictionary.Add("bool", myBool);

           sbyte mySbyte = 126;
           _dictionary.Add("sbyte", mySbyte);
           
           byte myByte = 254;
           _dictionary.Add("byte", myByte);

           short myShort = 32766;
           _dictionary.Add("short", myShort);

           ushort myUshort = 32766;
           _dictionary.Add("ushort", myUshort);

           int myInt = 2147483646;
           _dictionary.Add("int", myInt);

           uint myUint = 2147483646;
           _dictionary.Add("uint", myUint);

           long myLong = 9223372036854775806;
           _dictionary.Add("long",  myLong);

           ulong myUlong = 18446744073709551614;
           _dictionary.Add("ulong",  myUlong);

           char myChar = 'C';
           _dictionary.Add("char", myChar );

           float myFloat = 100.0F;
           _dictionary.Add("float", myFloat);

           double myDouble = 100.0;
           _dictionary.Add("double", myDouble);

           decimal myDecimal = 100.0M;
           _dictionary.Add("decimal ", myDecimal);

           string myString = "String";
           _dictionary.Add("string", myString);

           object myObject = "Any type";
           _dictionary.Add("object", myObject);
       }
       
        public void WritePrimitive()
        {
            Console.WriteLine("***** Primitive types start *****");
            
            foreach (KeyValuePair<string, dynamic> keyValue in _dictionary)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
            Console.WriteLine("***** Primitive types end *****");
            
        }
    }
}