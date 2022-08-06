using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1 // Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

//метод, определяющий длину окружности по заданному радиусу;
//метод, определяющий площадь круга по заданному радиусу;
//метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            double L = Cyrcle.GetL(r);
            double S = Cyrcle.GetS(r);
            string belong = Cyrcle.ChekBelongPoint(x, y, r, x0, y0);
            Console.WriteLine(L);
            Console.WriteLine(S);
            Console.WriteLine(belong);
            Console.ReadKey();
        }
    }
}
