using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;
            GetParam(a, out V, out S);
            Console.WriteLine("Площадь поверхности куба будет равна {0} м2", S);
            Console.WriteLine("Объем куба будет равен {0} м3", V);
            Console.ReadKey();
        }
        static void GetParam(double a, out double V, out double S)
        {
            V = Math.Pow(a,3);
            S = 6 * Math.Pow(a, 2);
        }
    }
}
