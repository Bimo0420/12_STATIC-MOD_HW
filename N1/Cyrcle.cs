using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    static class Cyrcle
    {
        static public double GetL (double r)
        {
            return 2 * Math.PI*r;
        }
        static public double GetS(double r)
        {
            return Math.PI * r*r;
        }
        static public string ChekBelongPoint(double x, double y, double r, double x0, double y0)
        {
            if (r * r == (x - x0)*(x - x0) + (y - y0)*(y - y0))
                return "Точка принадлежит окружности";
            return "Точка не принадлежит окружности";
        }
    }
}
