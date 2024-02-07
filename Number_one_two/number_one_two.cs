using System;

namespace Number_one_two
{
    class number_one_two
    {
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
