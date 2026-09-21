using System.Drawing;

class Program
{
    static void Main()
    {
        /*Colors c = new Colors(100, 150, 200);

        Console.WriteLine(c.getRed());
        Console.WriteLine(c.getGreen());
        Console.WriteLine(c.getBlue());
        Console.WriteLine(c.getAlpha());

        Console.WriteLine("Grayscale: " + c.greyScale());

        c.setRed(200);

        Console.WriteLine("New Red: " + c.getRed());
        */
        // Create two different balls of different colors and sizes.
        Ball bigRed = new Ball(new Colors(255, 0, 0), 5);
        Ball littlePurple = new Ball(new Colors(255, 0, 255), 3);

        // Throw the big red ball around a few times.
        bigRed.Throw();
        bigRed.Throw();
        bigRed.Throw();
        Console.WriteLine(bigRed.total());

        // Keep throwing it, and make sure that the number of
        // times thrown keeps going up.
        bigRed.Throw();
        bigRed.Throw();
        Console.WriteLine(bigRed.total());

        // Throws the little purple ball around.
        littlePurple.Throw();
        littlePurple.Throw();
        Console.WriteLine(littlePurple.total());

        // Pop the little purple ball and make sure that the throw
        // count doesn't keep going up if the ball has been popped.
        littlePurple.pop();
        littlePurple.Throw();
        Console.WriteLine(littlePurple.total());

        Console.ReadKey();
    }
}