using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


namespace Number_two_seven
{
    class Number_two_seven
    {
        /*
            2.7.2. 
            
         */

        static void Main(string[] args)
        {
            int x;
            int y;
            double s = 0;

            Console.WriteLine("Введите x: ");
            while (!int.TryParse(Console.ReadLine(), out x)) { Console.WriteLine("Введите x: "); }

            Console.WriteLine("Введите y: ");
            while (!int.TryParse(Console.ReadLine(), out y)) { Console.WriteLine("Введите y: "); }

            if (x < 1)
                s = x + Math.Sin(y);
            else if (1 <= x && x < 4)
                s = x - 3 * Math.Pow(Math.E, y);
            else if (x >= 4)
                s = Math.Pow(x, 2) - Math.Pow(y, 2);
            else
            {
                Console.WriteLine($"Условия не соответствуют");
                Environment.Exit(0);
            }

            Console.WriteLine($"Ответ: {s.ToString("F" + 2)}");

        }
    }
}
