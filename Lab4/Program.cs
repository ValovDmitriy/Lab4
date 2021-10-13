using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число больше 0");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Pow=0;
            if (Number<=0)
            {
                Console.WriteLine("Неправильный ввод данных");
            }
            else
            {
                for (int i = 1; i < Number + 1; i++)
                {
                    Pow += 2 * i - 1;
                    Console.WriteLine("Число {0} в квадрате равно {1}",i,Pow);
                }
            }
            
        }
    }
}
