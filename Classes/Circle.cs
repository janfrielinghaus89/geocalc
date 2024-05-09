using System;

public class Circle
{

    public float radius;

    public Circle()
    {
        radius = 0;
    }

    public float Perimeter(float radius)
    {
        return (2 * (float)Math.PI * radius);
    }

    public float Area(float radius)
    {
        return (float)Math.PI * radius * radius;
    }

    public float Diameter(float radius)
    {
        return 2 * radius;
    }
}
