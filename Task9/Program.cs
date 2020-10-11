using System;
using System.Text;
namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("x= ");
            int x;
            int res = 0;
            int fact = 1;
            x = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                res += fact;
                fact = 1;
            }
            Console.WriteLine($"Сума факторіалів: {res}");
        }
    }
}
