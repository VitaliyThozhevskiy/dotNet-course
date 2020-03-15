using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public static class PrimitiveType
    {

       public static Dictionary<string, dynamic> SetPrimitiveType()
       {
       
        Dictionary<string, dynamic> _primitivs = new Dictionary<string, dynamic>();
        
           bool myBool = true;
           _primitivs.Add("bool", myBool);

           sbyte mySbyte = 126;
           _primitivs.Add("sbyte", mySbyte);
           
           byte myByte = 254;
           _primitivs.Add("byte", myByte);

           short myShort = 32766;
           _primitivs.Add("short", myShort);

           ushort myUshort = 32766;
           _primitivs.Add("ushort", myUshort);

           int myInt = 2147483646;
           _primitivs.Add("int", myInt);

           uint myUint = 2147483646;
           _primitivs.Add("uint", myUint);

           long myLong = 9223372036854775806;
           _primitivs.Add("long",  myLong);

           ulong myUlong = 18446744073709551614;
           _primitivs.Add("ulong",  myUlong);

           char myChar = 'C';
           _primitivs.Add("char", myChar );

           float myFloat = 100.0F;
           _primitivs.Add("float", myFloat);

           double myDouble = 100.0;
           _primitivs.Add("double", myDouble);

           decimal myDecimal = 100.0M;
           _primitivs.Add("decimal ", myDecimal);

           string myString = "String";
           _primitivs.Add("string", myString);

           object myObject = "Any type";
           _primitivs.Add("object", myObject);
           
           return _primitivs;
       }
       
        public static void WritePrimitive()
        {
            Console.WriteLine("***** Primitive types start *****");
            
            foreach (KeyValuePair<string, dynamic> keyValue in SetPrimitiveType())
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
            Console.WriteLine("***** Primitive types end ***** \n");
            
        }
    }
}