using System;
using System.Runtime.InteropServices;

namespace Math1
{
    internal class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double x = 2*a + Math.Sin(Math.Abs(3 * a));
            x = Math.Round(Math.Sqrt(x / 3.56d), 3);
            Console.WriteLine(x);
        }
    }
}