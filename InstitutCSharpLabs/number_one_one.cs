using System;

namespace Number_one_one
{
    class number_one_one
    {
        [STAThread]
        static void Main(string[] args)
        {
            double s = 0;

            Console.WriteLine("Введите элемент f: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите элемент x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите элемент y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            s = (2 * Math.Pow(f, 2) + Math.Sin(7 * x)) / (3 * Math.Pow(x, 3) + Math.Pow(Math.E, (-2 * y)) + 1);

            Console.WriteLine($"Элемент s: {Math.Round(s, 3).ToString()}");

            Console.ReadLine();
        }
    }
}
