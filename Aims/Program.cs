using System.ComponentModel.Design;
using System.Diagnostics;
using System.Dynamic;
using System.Xml.Linq;

namespace Aims
{
    internal class Program
    {
        static bool WaitForInputBool(char Comparation = 'y')
        {
            string s = Console.ReadLine();
            return s.Length == 1 &&  char.ToLower(s[0]) == Comparation;
        }
        //Ждёт ввода с консоли, переспрашивает пользователя, если он ввёл некорректное целое число
        //Проверяет принадлежит ли число промежутку
        //Используется при изменении глобальных настроек
        static short WaitForInputShort(int MinRange, int MaxRange)
        {
            short output;
            while (true)
            {
                if (!short.TryParse(Console.ReadLine(),out output))
                {
                    Console.WriteLine("Введено некорректное целое число, попробуйте снова");
                    continue;
                }
                if (output < MinRange)
                {
                    Console.WriteLine("Введено слишком маленькое число, " +
                        "оно должно быть больше или равно {0}, попробуйте снова", MinRange);
                    continue;
                }
                if (output > MaxRange)
                {
                    Console.WriteLine("Введено слишком большое число, " +
                        "оно должно быть меньше или равно {0}, попробуйте снова", MaxRange);
                    continue;
                }
                return output;
            }
        }

        //Функция опрашивающая пользователя и обновляющая значение глобальных настроек
        static void SetUpNewGlobalSettings(ref short Sleep, ref short MaxValue, ref short MaxScore, ref short Step)
        {
            Console.WriteLine("Введите Задержку в миллисекундах");
            Sleep = WaitForInputShort(10, 300);

            Console.WriteLine("Введите Ширину мишени");
            MaxValue = WaitForInputShort(1, 50);

            Console.WriteLine("Введите Количество секций");
            MaxScore = WaitForInputShort(1, MaxValue);

            int stepMax = Math.Min(10,MaxValue / MaxScore);

            Console.WriteLine("Введите Ширину секции");
            Step = WaitForInputShort(1, stepMax);

        }
        //Функция для получения одной из координат выстрела
        static double GetShotInput(short MaxValue, short Delay, char Name)
        {
            //Принимает значения от -MaxValue до MaxValue - 0.5, включительно
            //Используется, для более равномерного распределения CurrentValue
            double CurrentAimValue = -MaxValue;
            //Случайное значение на отрезке от CurrentAimValue до CurrentAimValue + 0.5
            //Истинное случайное значение
            double CurrentValue = 0;
            Random rnd = new Random();
            
            while (!Console.KeyAvailable)
            {   
                CurrentValue = CurrentAimValue + rnd.NextDouble()/2;

                //Обновляем счётчик
                CurrentAimValue += 0.5;

                //Если вышли за границу то возвращаемся на начальное положение
                if (CurrentAimValue > MaxValue - 0.5f)
                    CurrentAimValue = -MaxValue;

                //Вывод числа
                Console.Write(CurrentValue);
                Console.CursorLeft = 0;
                
                Thread.Sleep(Delay);
            }
            Console.ReadKey(true);

            return CurrentValue;
        }
        //Функция высчитывающая счёт исходя из того куда попал игрок
        static int GetScore(double x, double y, short MaxScore, short Step)
        {
            double dist = Math.Sqrt(x * x + y * y);
            return Math.Max(0,MaxScore - (int)Math.Round(dist / Step));
        }
        static void Main(string[] args)
        {
            short MaxValue = 15;
            short Sleep = 30;
            short Step = 1;
            short MaxScore = 10;

            Console.WriteLine("Изменить установки игры? (Y/y - Да)");
            if (WaitForInputBool())
                SetUpNewGlobalSettings(ref Sleep, ref MaxValue, ref MaxScore, ref Step);
            
            int TotalScore = 0;
            //Строка для вывода разграничителей в виде полосок 
            string Line = new string('─', 28) + "\n";
            do
            {
                //Определение координаты X
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Line+"Определяется X ... \n"+ Line);
                Console.ForegroundColor = ConsoleColor.White;
                double x = GetShotInput(MaxValue, Sleep, 'X');
                Console.WriteLine("X = {0}", x);

                //Определение координаты Y
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(Line + "Определяется Y ... \n" + Line);
                Console.ForegroundColor = ConsoleColor.White;
                double y = GetShotInput(MaxValue, Sleep, 'Y');
                Console.WriteLine("Y = {0}", y);


                int Score = GetScore(x, y, MaxScore, Step);
                TotalScore += Score;

                Console.Write(Line + "Счёт за текущий выстрел: {0}" +
                    "\nСуммарный счёт: {1}\n" + Line, Score, TotalScore);

                Console.WriteLine("Завершить игру? (Y/y - Да)");
            } while (!WaitForInputBool());
        }
    }
}