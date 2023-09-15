/// ClassWork 15.09.2023

/// C#

/// Сергей Владимирович 

/// .NET


/// C sharp
/* Сам язык - компилируемый, но в исполняемом файле есть интерпретатор
 * 
 * Имеется встроенный обфускатор
 * 
 * Рефлектор - инструмент реверсинжиниринга. С# позволяет за счет включенных метаданных в проект легко превращать код промежуиочного языка обратно в C#
 * 
 * 
 * Плюсы:
 * 1. Быстрое создание кода
 * 2. Поддержка одной компанией (Microsoft)
 * 3. Удобство создания оконных приложений
 * 
 * Минусы:
 * 1. Медленнее С++
 * 
 * 
 * Типы данных аналогично С++, кроме:
 * 1) bool - отдельный тип, не целочисленный
 * 2) есть категория типов данных NULLable, принимающие значение NULL (например string)
 * 
 * CIL - common intermadiate language
 * 
 * CLR - common language run-time
 * 
 * BCL - base classes library (аналог BCL)
 * 
 * metadata:
 * 1) CTS - common types system
 * 2) CLS - common language specification
 * 
 */

/// .NET
/*
Платформа создания приложений
 
 */

using System;
using System.Globalization;

namespace IDA_ClassWork_Csharp_1._1_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int num_1, num_2, num_3;
             Console.Write("Enter num1 ");
             num_1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("Enter num2 ");
             num_2 = Convert.ToInt32(Console.ReadLine());

             num_3 = num_1 + num_2;

             Console.WriteLine(num_3);*/

            Program p = new Program();
            //p.FuzzBizz();
            //p.Percentage();

            Console.WriteLine(p.Num_to_Str());

            Console.ReadKey();
        }

        public void FuzzBizz()
        {
            Console.Write("Welcome to FizzBuzz!\nEnter number ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 && num <=100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (num % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (num % 5 == 0)
                    Console.WriteLine("Buzz");
                else 
                    //(num % 3 != 0 && num % 5 != 0);
                        Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("ERROR_RANGE");
            }

            /*foreach (var i = 0; i < )*/

        }

        public void Percentage()
        {
            Console.Write("Welcome to Percent_app!\nEnter number ");
            double num = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter percent ");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.Write((num/100)*percent);            
        }

        //  public string Num_to_Str()
        public int Num_to_Str()
        {    

            Console.Write("Enter num1 ");
            string tmp = Console.ReadLine();
            Console.Write("Enter num2 ");
            tmp +=Console.ReadLine();
            Console.Write("Enter num3 ");
            tmp += Console.ReadLine();
            Console.Write("Enter num4 ");
            tmp += Console.ReadLine();

            return Convert.ToInt32(tmp);
        }

    }
}
