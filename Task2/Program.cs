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
            Console.Write("m= ");
            double m;
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("n= ");
            double n;
            n = Convert.ToDouble(Console.ReadLine());
            double z1, z2;
            z1 = ((m-1)*Math.Sqrt(m)-(n-1) * Math.Sqrt(n))/(Math.Sqrt(Math.Pow(m,3)*n)+n*m+Math.Pow(m,2)-m);
            z2 = (Math.Sqrt(m)- Math.Sqrt(n))/m;
            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");
        }
    }
}