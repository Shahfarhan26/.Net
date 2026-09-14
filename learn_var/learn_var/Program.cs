using System;

namespace var
{
    class Variable
    {
        static void Main(string[] args)
        {
            byte a = 1;
            sbyte b = 2;
            short c = 3;
            ushort d = 4;
            int e = 5;
            uint f = 6;
            long l = 7;
            ulong m = 8;
            char n = '@';
            float ab = 9.1f;
            double bc = 500.21;
            decimal cd = 60.11m;
            bool hai = true;
            string name = "farhan";
            Console.WriteLine("byte = " + a + "\nsbyte = " + b +  "\nshort = " + c + "\nbool = " + hai + "\nname = " + name);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}