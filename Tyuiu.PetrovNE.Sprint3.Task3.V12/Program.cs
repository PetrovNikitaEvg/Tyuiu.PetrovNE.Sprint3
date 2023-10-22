using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PetrovNE.Sprint3.Task3.V12.Lib;


namespace Tyuiu.PetrovNE.Sprint3.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Петров Н. Е.  | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Петров Никита Евгеньевич | АСОиУБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв k,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: bkkrk ckkkcs ksr             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string value = "krk ckkkcs ksr";
            char chr = 'k';
            int res = ds.GetMaxCharCount(value, chr);

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомый символ: " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);

            Console.ReadLine();

        }
    }
}
