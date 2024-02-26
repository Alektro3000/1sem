using Microsoft.VisualBasic;
using System.Formats.Asn1;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calendar
{
    internal class Program
    {
        static string Repeat(string center, string separator, int count = 7)
        {
            string ans = center;
            for(int i = 1; i< count; i++)
            {
                ans += separator + center;
            }
            return ans;
        }
        static void DrawCalendar(DateTime date)
        {
            date = date.AddDays(1-date.Day);

            Console.WriteLine("┌" + Repeat("────", "┬") + "┐");
            for (int i = date.Day - (int)date.DayOfWeek, end = DateTime.DaysInMonth(date.Year, date.Month); i < end;)
            {
                Console.Write("│");
                for (int j = 0; j < 7; j++, i++)
                {
                    int a = date.AddDays(i).Day;
                    Console.Write((a >= 10 ? " " : "  ") + a + " │");
                }
                Console.WriteLine();
                if (i < end)
                    Console.WriteLine("├" + Repeat("────", "┼") + "┤");
            }
            Console.WriteLine("└" + Repeat("────", "┴") + "┘");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год и месяц");

            DrawCalendar(new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), 3));

        }
    }
}
