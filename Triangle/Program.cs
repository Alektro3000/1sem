using System.Data;
using System.Drawing;

namespace Triangle
{
    internal class Program
    {
        //Test if this three points in clockwise order,
        //If they are collinear return true
        static bool isClockWise(Point p1, Point p2, Point p3)
        {
            return (p2 - p1) * (p3 - p1) <= 0;
        }
        static Point ReadPointFromConsole()
        {
            string[] a = Console.ReadLine().Split();
            return new(double.Parse(a[0]), double.Parse(a[1]));
        }
        static void Main(string[] args)
        {
            Point p1 = ReadPointFromConsole();
            Point p2 = ReadPointFromConsole();
            Point p3 = ReadPointFromConsole();

            //Cross product to check if all three points collinear
            if ((p2 - p1) * (p3 - p1) == 0)
            {
                Console.WriteLine("Не треугольник");
                return;
            }

            //If points are not in clockwise order, reorder them
            if (!isClockWise(p1, p2, p3))
            {
                Point t = p2;
                p2 = p3;
                p3 = t;
            }

            Point P = ReadPointFromConsole();

            //Point must be from one side(inwards) for all sides of triangle
            if (isClockWise(p1, p2, P) &&
                isClockWise(P, p2, p3) &&
                isClockWise(p1, P, p3))
                Console.WriteLine("Внутри");
            else
                Console.WriteLine("Снаружи");
        }
    }
}