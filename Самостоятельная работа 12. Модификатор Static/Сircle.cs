using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_12.Модификатор_Static
{
    static class Round
    {
        //Метод нахождения длины окружности
        static public double GetLenght(double r)
        {
            return 2 * Math.PI * Math.Abs(r);
        }
        //Метод нахождения площади окружности
        static public double GetSquare(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        //Метод определения принадлежности точки к окружности
        static public string GetAffiliation(double x, double y, double r)
        {
            if (Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)) <= Math.Abs(r))
                return "Точка с указанными координатами принадлежит окружности";
            else
                return "Точка с указанными координатами не принадлежит окружности";
        }
    }
}
