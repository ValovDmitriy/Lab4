using System;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность целых чисел:");
            int Number;
            int NumberPoz = 0;
            int NumberNeg = 0;
            do
            {
                Number = Convert.ToInt32(Console.ReadLine());
                if (Number > 0)
                {
                    NumberPoz++;
                }
                else
                {
                    if (Number<0)
                    {
                        NumberNeg++;
                    }
                    else
                    {
                        break;
                    }
                }
            } while (Number!=0);
            Console.WriteLine("Количество положительных чисел {0}",NumberPoz);
            Console.WriteLine("Количество отрицательх чисел {0}", NumberNeg);
            if (NumberPoz > NumberNeg)
            {
                Console.WriteLine("Количество положительных чисел больше");
            }
            else
            {
                if (NumberPoz == NumberNeg)
                {
                    Console.WriteLine("Количество отрицательных и положительных чисел одинакого");
                }
                else
                {
                    Console.WriteLine("Количество отрицательных чисел больше");
                }
            }
              
        }
    }
}
