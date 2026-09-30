class Geometry
{
    public double CalcCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public double CalcCirclePerimeter(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public double CalcRectangleArea(double length, double width)
    {
        return length * width;
    }

    public double CalcRectanglePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }

    public double CalcTriangleArea(double baseValue, double height)
    {
        return 0.5 * baseValue * height;
    }

    public double CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }
}