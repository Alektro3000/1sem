namespace RecPal
{
    internal class Program
    {
        static bool IsPalindrom(string str)
        {
            if(str.Length < 2)
                return true;
            if (char.ToLower(str[0]) != char.ToLower(str[str.Length-1]))
                return false;
            return IsPalindrom(str.Substring(1,str.Length-2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrom("К_к1"));
        }
    }
}
