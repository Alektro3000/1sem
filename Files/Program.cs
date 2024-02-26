using System.IO;

// C:\Users\Al\Desktop
namespace Files
{
    internal class Program
    {
        static int GetDepth(string folder)
        {
            int mx = 0;
            foreach (string currentFile in Directory.GetDirectories(folder))
            {
                mx = Math.Max(mx, GetDepth(currentFile)+1);
            }
            return mx;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя папки");
            Console.WriteLine(GetDepth(Console.ReadLine()));
            Console.WriteLine("Чтобы выйти из программы нажмите Enter");
            Console.ReadLine();
        }
    }
}
