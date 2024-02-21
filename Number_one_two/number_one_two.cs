using System;

namespace Number_one_two
{
    class number_one_two
    {

        /*
            1.2.2. Найдите площадь кольца, внутренний радиус которого равен r, а
            внешний – заданному числу R. Вычислите длину внешней окружности.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите элемент r (внутренего кольца): ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите элемент R (внешнего кольца): ");
            double R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Площадь кольца: {Math.Round(Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2)), 2)}");
            Console.WriteLine($"Длина окружности: {Math.Round(2 * Math.PI * R, 2)}");

            Console.ReadLine();
        }
    }
}
