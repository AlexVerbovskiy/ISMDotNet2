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
            Console.Write("n= ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("a= ");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            double res = 1;
            for(int i = 0; i < n; i++)
            {
                res *= a;
            }
            Console.WriteLine($"Результат: {res}");
        }
    }
}
