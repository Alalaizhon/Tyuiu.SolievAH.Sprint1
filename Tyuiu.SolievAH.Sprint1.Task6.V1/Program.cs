using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SolievAH.Sprint1.Task6.V1.Lib;

namespace Tyuiu.SolievAH.Sprint1.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ и нажмите enter: ");
            string value = Console.ReadLine();
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Солиев А. Х. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Солиев Алижон Хотамжонович | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа*");
            Console.WriteLine("*  Программа должна завершать работу в результате ввода, например, точки. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(value);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SymbolCode(value);
            Console.WriteLine("Ваш символ и код:" + res);



            Console.ReadKey();

        }
    }
}
