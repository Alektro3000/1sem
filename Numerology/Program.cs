namespace Numerology
{
    internal class Program
    {
        static int GetPartSumOfDigits(int Number)
        {
            int sum = 0;
            for (int i = 1; i <= Number; i *= 10)
                sum += (Number/i) % 10;
            return sum;
        }
        static int GetSumOfDigits(int Number)
        {
            while (Number >= 10)
            {
                Number = GetPartSumOfDigits(Number);
            }
            return Number;
        }
        static void Main(string[] args)
        {
            int Input = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetSumOfDigits(Input));
        }
    }
}