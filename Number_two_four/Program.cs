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
                double curs = 0;

                Console.WriteLine("Введите колчество таблеток в упаковке:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во дней: ");
                int d = int.Parse(Console.ReadLine());


                curs = n * 3;

                Console.WriteLine($"Ответ: {Math.Ceiling(Convert.ToDecimal(curs / d))}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
