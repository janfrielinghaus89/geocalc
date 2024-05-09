using System;
using Math;

public class Circle {
    
    public float radius;

    public Circle() {
        radius = 0;
    }

    public float Perimeter (float radius)
    {
        return (2 * Math.Pi() * radius);
    }

    public float Area (float radius)
    {
        return Math.Pi() * Math.Pow(radius, 2);
    }

    public float Diameter (float radius)
    {
        return radius * radius;
    }
}