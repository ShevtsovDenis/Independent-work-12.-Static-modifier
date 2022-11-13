using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Самостоятельная_работа_12.Модификатор_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            //Вызов методов определения длины и площади
            double lenght = Round.GetLenght(r);
            double square = Round.GetSquare(r);
            Console.WriteLine($"Длина окружности ={lenght:f2} \nПлощадь окружности ={square:f2}");
            Console.Write("Введите координату Х=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату У=");
            double y = Convert.ToDouble(Console.ReadLine());
            //Вызов метода определения принадлежности
            string affiliation = Round.GetAffiliation(x, y, r);
            Console.WriteLine($"{affiliation}");
            Console.ReadKey();
        }
    }
}
