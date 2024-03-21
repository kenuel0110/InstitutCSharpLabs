using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Number_two_six
{
    class Number_two_six
    {
        //2.4.2. 
        //Найти сумму четных цифр заданного четырехзначного числа.
        static void Main(string[] args)
        {
            int x;
            int sum = 0;

            Console.WriteLine("Введите четырёх значное число: ");
            while (!int.TryParse(Console.ReadLine(), out x) || x < 1000 || x > 9999) { Console.WriteLine("Вы не ввели четырёх значное число, или ЧИСЛО в принципе. Пожалуйста, введите четырёх значное число: "); }

            int digit1 = int.Parse(x.ToString()[0].ToString());
            if (digit1 % 2 == 0)
            {
                sum += digit1;
            }

            int digit2 = int.Parse(x.ToString()[1].ToString());
            if (digit2 % 2 == 0)
            {
                sum += digit2;
            }

            int digit3 = int.Parse(x.ToString()[2].ToString());
            if (digit3 % 2 == 0)
            {
                sum += digit3;
            }

            int digit4 = int.Parse(x.ToString()[3].ToString());
            if (digit4 % 2 == 0)
            {
                sum += digit4;
            }

            if (sum == 0)
                Console.WriteLine($"Чётных чисел не найдено");
            else
                Console.WriteLine($"Ответ: {sum}");
        }
    }
}
