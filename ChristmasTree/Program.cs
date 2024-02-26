namespace ChristmasTree
{
    internal class Program
    {
        static string RepeatLine(int repeatCount, string text)
        {
            string line = "";
            for (int q = 0; q < repeatCount; q++)
                line += text;
            return line+'\n';
        }
        static void Main(string[] args)
        {
            int n, m, k;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            string str = "";

            for (int j = 0; j < k; j++)
            {
                //Find Segment for one tree
                str += RepeatLine(m, new string(' ', k - j) +
                          new string('#', j + j + 1) +
                          new string(' ', k - j - 1));
            }
            str += RepeatLine(m, new string(' ', k) + '#' + new string(' ', k - 1));
            str += '\n';

            Console.WriteLine(RepeatLine(n,str));
            
        }
    }
}