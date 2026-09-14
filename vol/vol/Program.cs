using System;
namespace vol
{
    class Cyl
    {
        static void Main(string[] args)
        {
            const float pi = 3.14f;

            Console.Write("type in the height of the cylinder :\t");
            int h = Convert.ToInt32(Console.ReadLine());

            Console.Write("type in the radius of the cylinder :\t");
            int r = Convert.ToInt32(Console.ReadLine());

            float v = pi * r * r * h;
            Console.WriteLine("volume of a cylinder is\t" + v);

            float SA = 2 * pi * r * (r + h);
            Console.WriteLine("Surface area of a cylinder is\t" + SA);
        }
    }
}