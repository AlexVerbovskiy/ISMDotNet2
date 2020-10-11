using System;
using System.Text;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Довжина першої сторони: ");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Довжина другої сторони: ");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            int p, s;
            p = 2 * (a + b);
            s = a * b;
            Console.WriteLine($"Периметр прямокутника: {p}");
            Console.WriteLine($"Площа прямокутника: {s}");
        }
    }
}
