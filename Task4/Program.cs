using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("a= ");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b= ");
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c= ");
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            double d=Math.Pow(b,2)-4*a*c;
            Console.WriteLine($"D = {d}");
            if (d < 0)
            {
                Console.WriteLine($"Розв'язків не існує");
            }else if (d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Корінь один: {x}");
            } else
            {
                double x1 = (-b +Math.Sqrt(d))/ (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"Коренів два: {x1} та {x2}");
            }
        }
    }
}
