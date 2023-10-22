using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint3.Task2.V11.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task2.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do While, которая вычисляет сумму ряда*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            double value = 0.5; int startValue = 1; int stopValue = 15;
            double res = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("start = " + startValue);
            Console.WriteLine("end = " + stopValue);
            Console.WriteLine("x = " + value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"{Math.Round(res, 3)}");

            Console.ReadLine();
        }
    }
}
