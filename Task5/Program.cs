using System;
using System.Text;
namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Номер дня тижня= ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine($"День тижня: понеділок"); break;
                case 2: Console.WriteLine($"День тижня: вівторок"); break;
                case 3: Console.WriteLine($"День тижня: середа"); break;
                case 4: Console.WriteLine($"День тижня: четвер"); break;
                case 5: Console.WriteLine($"День тижня: п'ятниця"); break;
                case 6: Console.WriteLine($"День тижня: субота"); break;
                case 7: Console.WriteLine($"День тижня: неділя"); break;
                default: Console.WriteLine($"Введено некоректний номер дня"); break;
            }

        }
    }
}
