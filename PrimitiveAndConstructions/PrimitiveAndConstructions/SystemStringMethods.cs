using System;
using System.Collections.Generic;

namespace PrimitiveAndConstructions
{
    public static class SystemStringMethods
    {
        public static void WriteString()
        {
            Console.WriteLine("***** String methods start *****");
            
            string firstname = "Steven Clark";
            string lastname = "Clark";

            // Make String Clone
            Console.WriteLine(firstname.Clone());
            
            //Compare two string value and returns 0 for true and 1 for false
            Console.WriteLine(String.Compare(firstname, lastname, StringComparison.Ordinal));

            //Check whether specified value exists or not in string
            Console.WriteLine(firstname.Contains("ven")); 

            //Check whether specified value is the last character of string
            Console.WriteLine(firstname.EndsWith("n")); 
            
            //Compare two string and returns true and false
            Console.WriteLine(firstname.Equals(lastname));

            //Returns HashCode of String
            Console.WriteLine(firstname.GetHashCode());

            //Returns type of string
            Console.WriteLine(firstname.GetType());

            //Returns type of string
            Console.WriteLine(firstname.GetTypeCode());

            //Returns the first index position of specified value the first index position of specified value
            Console.WriteLine(firstname.IndexOf("e", StringComparison.Ordinal)); 

            //Covert string into lower case
            Console.WriteLine(firstname.ToLower());

            //Convert string into Upper case
            Console.WriteLine(firstname.ToUpper());

            //Insert substring into string
            Console.WriteLine(firstname.Insert(0, "Hello")); 

            //Check Whether string is in Unicode normalization from C
            Console.WriteLine(firstname.IsNormalized());

            //Returns the last index position of specified value
            Console.WriteLine(firstname.LastIndexOf("e", StringComparison.Ordinal));

            //Returns the Length of String
            Console.WriteLine(firstname.Length);

            //Deletes all the characters from begining to specified index.
            Console.WriteLine(firstname.Remove(5));

            // Replace the character
            Console.WriteLine(firstname.Replace('e', 'i')); 

            //Split the string based on specified value
            string[] split = firstname.Split(new char[] {'e'});


            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            //Check wheter first character of string is same as specified value
            Console.WriteLine(firstname.StartsWith("S")); 

            //Returns substring
            Console.WriteLine(firstname.Substring(2, 5));

            //Converts an string into char array.
            Console.WriteLine(firstname.ToCharArray());

            //It removes starting and ending white spaces from string.
            Console.WriteLine(firstname.Trim());

            Console.WriteLine("***** String methods end ***** \n");
        }
    }
}