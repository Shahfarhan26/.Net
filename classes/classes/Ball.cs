using System;
public class Ball
{
    private Colors color;
    private float radius;
    private int count;

    public Ball(Colors color, float radius)
    {
        this.color = color;
        this.radius = radius;
        this.count = 0;
    }
    public void pop()
    {
        radius = 0;
    }
    public void Throw()
    {
        if(radius > 0)
        {
            count++;
        }
        
    }
    public int total( )
    {
        return count;
    }
}

