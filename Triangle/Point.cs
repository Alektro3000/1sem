using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{    
    public struct Point
    {
        public double x;
        public double y;
        public Point(double NewX, double NewY)
        {
            x = NewX;
            y = NewY;
        }
        public static Point operator -(Point Left, Point Right)
        {
            return new Point(Left.x - Right.x, Left.y - Right.y);
        }
        public static double operator * (Point Left, Point Right)
        {
            return Left.x * Right.y - Right.x * Left.y;
        }
    }
}
