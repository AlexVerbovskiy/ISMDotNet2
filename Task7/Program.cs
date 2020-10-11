using System;
using System.Text;
namespace Task7
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
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                res += 1.0/i;
            }
            Console.WriteLine($"Результат: {res}");
        }
    }
}
