using System;

namespace Number_two_four
{
    class Number_two_four
    {
        /*
            2.4.2. Больному прописано лекарство, которое нужно принимать по т г 3 раза в день
            в течение 14 дней. Упаковка содержит п таблеток по 0,5г. 
            Какое наименьшее количество упаковок потребуется на весь курс лечения
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
