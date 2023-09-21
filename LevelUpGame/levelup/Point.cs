using System.Runtime.InteropServices;

public class Point
{

    public int X;
    public int Y;

    public Point() { }

    public Point(int X, int Y)
    {

        this.X = X;
        this.Y = Y;
    }


    static Point SumPoints(Point startingPoint, Point endingPoint)
    {

        return new Point(startingPoint.X + endingPoint.X, startingPoint.Y + endingPoint.Y);

    }


}