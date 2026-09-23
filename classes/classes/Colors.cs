using System;

public class Colors
{
     public int Red { get; set; }
     public int Green { get; set; }
     public int Blue { get; set; }
     public int Alpha { get; set; }

    public Colors(int r, int g, int b, int a)
    {
        Red = r;
        Green = g;
        Blue = b;
        Alpha = a;
    }
    public Colors(int r, int g, int b)
    {
        Red = r;
        Green = g;
        Blue = b;
        Alpha = 255;
    }
    public int greyScale()
    {
        return (Red + Green + Blue) / 3;
    }
}