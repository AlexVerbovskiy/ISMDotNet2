using System;
using System.Text;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("x= ");
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("a= ");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            double y;
            y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a)+(a-b)*Math.Pow(Math.Sin(a-b),2)+Math.Pow(10, -2)*(x-b);
            Console.WriteLine($"y = {y}");
        }
    }
}
