namespace Nums
{
    internal class Program
    {
        static string FindPrevious(int current, int depth = 3)
        {
            if (depth == 0)
                return current % 2 == 1 ? current.ToString()+" " : "";
            
            if (depth == 1 && current % 2 == 1)
                return "";

            string ans = FindPrevious(current * 2, depth - 1);
            if (current % 2 == 0)
                ans += FindPrevious(current - 3, depth - 1);
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindPrevious(int.Parse(Console.ReadLine()),7));
        }
    }
}