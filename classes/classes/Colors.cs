using System;

public class Colors
{
    private int red, green, blue, alpha;

    public Colors(int r, int g, int b, int a)
    {
        this.red = r;
        this.green = g;
        this.blue = b;
        this.alpha = a;
    }
    public Colors(int r, int g, int b)
    {
        this.red = r;
        this.green = g;
        this.blue = b;
        this.alpha = 255;
    }
    public int getRed()
    {
        return red;
    }
    public int getBlue()
    {
        return blue;
    }
    public int getGreen()
    {
        return green;
    }
    public int getAlpha()
    {
        return alpha;
    }
    public void setRed(int r)
    {
        this.red = r;
    }
    public void setBlue(int b)
    {
        this.blue = b;
    }
    public void setGreen(int g)
    {
        this.green = g;
    }
    public void setAlpha(int a)
    {
        this.alpha = a;
    }
    public int greyScale()
    {
        return (red + green + blue) / 3;
    }
}