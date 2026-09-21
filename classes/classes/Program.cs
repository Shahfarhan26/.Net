using System.Drawing;

class Program
{
    static void Main()
    {
        Colors c = new Colors(100, 150, 200);

        Console.WriteLine(c.getRed());
        Console.WriteLine(c.getGreen());
        Console.WriteLine(c.getBlue());
        Console.WriteLine(c.getAlpha());

        Console.WriteLine("Grayscale: " + c.greyScale());

        c.setRed(200);

        Console.WriteLine("New Red: " + c.getRed());
    }
}