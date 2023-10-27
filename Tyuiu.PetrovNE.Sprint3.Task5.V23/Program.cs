using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint3.Task5.V23.Lib;

namespace Tyuiu.PetrovNE.Sprint3.Task5.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя вложенный цикл,                            *");
            Console.WriteLine("* которая вычисляет сумму сумм ряда по формуле.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 2, startValue1 = 1, startValue2 = 1, stopValue1 = 3, stopValue2 = 10;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
;

            Console.WriteLine("Старт шага первой суммы ряда: " + startValue1);
            Console.WriteLine("Конец шага первой суммы ряда: " + stopValue1);
            Console.WriteLine("Старт шага второй суммы ряда: " + startValue2);
            Console.WriteLine("Конец шага второй суммы ряда: " + stopValue2);
            Console.WriteLine("Число X: " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
