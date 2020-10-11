using System;
using System.Text;
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("a= ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            int b;
            int res = 1;
            b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                res *= i;
            }
            Console.WriteLine($"Добуток всіх чисел на проміжку від {a} до {b} дорівнює: {res}");
        }
    }
}
