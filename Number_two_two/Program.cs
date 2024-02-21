using System;

namespace Number_two_two
{
    class Number_two_two
    {

        /*
            2.2.2. Грузовой автомобиль выехал из одного города со скоростью v1 км/ч.
            Через t ч в этом же направлении выехал легковой автомобиль со скоростью v2 км/ч.
            Составить программу, определяющую, догонит ли легковой автомобиль грузовой через t1 ч после своего выезда
        */

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите v1 точки: ");
                int v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите v2 точки: ");
                int v2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите t точки: ");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите t1 точки: ");
                int t1 = int.Parse(Console.ReadLine());

                if (v1 * t1 < v2 * t)
                    Console.WriteLine("Догонит");
                else
                    Console.WriteLine("Не Догонит");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
