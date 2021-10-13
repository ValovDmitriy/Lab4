using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину А прямоугольника");
            int lenghA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину B прямоугольника");
            int lenghB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину C прямоугольника");
            int lenghC = Convert.ToInt32(Console.ReadLine());
            int inLenghB = 0;
            int inLenghA = 0;
            int stroka = 0;
            int stolbets = 0;
            while (lenghC <= lenghB)
            {
                lenghB -= lenghC;
                inLenghB++;
            }
            while (lenghC <= lenghA)
            {
                lenghA -= lenghC;
                inLenghA++;
            }
            while (stolbets < inLenghB)
            {
                stolbets++;
                stroka += inLenghA;
            }    
            Console.WriteLine(stroka);
        }
    }
}
