﻿using System;

namespace Number_two_three
{
    class Number_two_three
    {
        /*
            2.3.2.
        */

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите a: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите c: ");
                int c = int.Parse(Console.ReadLine());
                double v = 0;

                if (c >= 2)
                    v = a + Math.Sqrt(2 * c);
                else if (c < 2)
                    v = a - Math.Cos(3 * c);

                Console.WriteLine($"Ответ: {v}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
