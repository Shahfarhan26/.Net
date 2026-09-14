//first program of mine. Wish me luck!
/* a using directive such as system is a library containg a lot of methods that
 * are used throughout the program.
 */
using System;
//namespace is the highest form of grouping.
namespace myFirst
{
    // class is a containner which contains methods and data in a program and is a
    // fundamental p[art of oop's concept.
    class Helo
    {
        //this ia a method specificallly main method i.e., entry point to program.
        static void Main(string[] args)
        {
            //variable 
            int x, y, z;
            x = 10;
            y = 20;
            z = x + y;
            // to print
            Console.WriteLine(z);
            Console.ReadKey();
            Console.WriteLine("I'm sorry, Dave. I'm afraid | can't do that.");
        }
    }
}
