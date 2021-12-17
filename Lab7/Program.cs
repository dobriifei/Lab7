using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double с = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника ");
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            if ((a + b < с) || (a + с < b) || (b + с < a) || (d + e < f) || (d + f < e) || (e + d < f))
            {
                Console.WriteLine(" заданные прямые не образуют два треугольника");
                Console.ReadKey();
            }
            else
            {
                double S1 = FormulaGerona(a, b, с);
                double S2 = FormulaGerona(d, e, f);
                Console.WriteLine("Площадь первого треугольника {0:f2}", S1);
                Console.WriteLine("Площадь второго треугольника {0:f2}", S2);
                if (S1 < S2)
                {
                    Console.WriteLine("Площадь второго треугольника {1:f2} больше площади первого треугольника {0:f2}", S1, S2);
                }
                else
                    if ((S2 < S1))
                    Console.WriteLine("Площадь первого треугольника {0:f2} больше площади второго треугольника{1:f2}", S1, S2);
                else
                    Console.WriteLine("Площади треугольников равны");
                Console.ReadKey();
            }
        }
        static double FormulaGerona(double x, double y, double z)
        {
            double p_perimetr = (x + y + z) / 2;
            double summa = Math.Sqrt(p_perimetr * (p_perimetr - x) * (p_perimetr - y) * (p_perimetr - z));
            return summa;
        }
    }
}
