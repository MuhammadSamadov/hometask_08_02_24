namespace hw2;

public static class Treugol
{
    public static double CalcTriangleArea(double @base, double height)
    {
        return 0.5*@base*height;
    }
    public static double CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1+side2+side3;
    }
}
