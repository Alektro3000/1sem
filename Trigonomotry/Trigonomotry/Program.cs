
using System.Runtime.Intrinsics.X86;

namespace Trigonomotry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, e;
            x = Convert.ToDouble(Console.ReadLine());
            
            //x = x / 180 * Math.PI;
            /*
            x = x % (2 * Math.PI);
            int anssign = 1;
            if (x < 0)
                x += 2* Math.PI;
            if (x > Math.PI)
            {
                anssign = -1;
                x -= Math.PI;
            }
            if (x > Math.PI / 2)
                x = Math.PI - x;
            */
            e = Convert.ToDouble(Console.ReadLine());

            double ans = x;
            int j = 2;
            double xn = x;
            double xsqr = x * x;

            while (e < xn || xn < -e || j < 5)
            {
                xn *= -xsqr/j++/j++;
                ans += xn;
                
            }
            Console.WriteLine(ans);
            //Console.WriteLine(ans * anssign);

        }
    }
}