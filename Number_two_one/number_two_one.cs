using System;

namespace Number_two_one
{
    class number_two_one
    {

        /*
          Картинка 2.1.2
        */

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x точки: ");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y точки: ");
                double y = double.Parse(Console.ReadLine());

                if (((x >= -1 && x <= 1) && (y >= 0 && y <= 1)) || (Math.Pow(x,2) + Math.Pow(y, 2) <= 1))
                    Console.WriteLine("Принадлежит");
                else
                    Console.WriteLine("Не принадлежит");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
