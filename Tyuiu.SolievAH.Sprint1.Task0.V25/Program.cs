using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint1.Task0.V25.Lib;


namespace Tyuiu.SolievAH.Sprint1.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Солиев А. Х. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Солиев Алижон Хотамжонович | СМАРТб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет следующее выражение               *");
            Console.WriteLine("* (30 / 6 - 4 ) *3.                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(30 / 6 - 4 ) *3");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());


            Console.ReadKey();
        }
    }
}
