using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint1.Task1.V27.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task1.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x, y через enter: ");
            double x, y;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
           
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Солиев А. Х. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Солиев Алижон Хотамжонович | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет следующее выражение               *");
            Console.WriteLine("* (x + y ) / 2.                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(x +" "+ y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
