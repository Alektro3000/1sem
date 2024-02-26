using System.Runtime.CompilerServices;

namespace MakeNumber
{
    internal class Program
    {
        static string? FindPath(uint num, uint a, uint b)
        {
            if (num == 1)
                return "";

            if ((num % b) == 0)
            {
                string? Mul = FindPath(num / b, a, b);

                if (Mul != null)
                {
                    return Mul + "*" + b;
                }
                    
                
            }

            if (num <= a)
                return null;

            string? Add = FindPath(num - a, a, b);
            if (Add != null)
                return Add + "+" + a;
            else
                return null;
        }
        static void Main(string[] args)
        {
            string Ans = FindPath(26, 3, 2);
            if (Ans != null)
                Console.WriteLine(Ans);
            else
                Console.WriteLine("Данное число невозможно получить из 1");
        }
    }
}
