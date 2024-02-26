namespace SimpleTriange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double max = Math.Max(a, Math.Max(b,c));
            Console.WriteLine(max <= a + b + c - max ? "YES" : "NO");
        }
    }
}