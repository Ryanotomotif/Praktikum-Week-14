using System;

namespace Praktikum_Week_14
{
    public class PrimaorNonPrima
    {
        public static int Prima(int input)
        {
            int hitung = 0;
            int i, j;
            for (i = 1; i <= input; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        hitung += 1;
                    }
                }
                if (hitung == 2)
                {
                    Console.Write(i + " ");
                }
                hitung = 0;
            }
            return i;
        }

        public static int NonPrima(int input)
        {
            Console.Write("1 ");
            int hitung = 0;
            int i, j;
            for (i = 1; i <= input; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        hitung += 1;
                    }
                }
                if (hitung > 2)
                {
                    Console.Write(i +" ");
                }
                hitung = 0;
            }
            return i;
        }
        
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.Write("Input : ");
                int input = Convert.ToInt32(Console.ReadLine());
                int hitung = 0;
                for (int i = 1; i <= input; i++)
                {
                    int hasil = input % i;
                    if (hasil == 0)
                        hitung = hitung + 1;
                }
                if (hitung == 2)
                    Prima(input);
                else
                    NonPrima(input);
			}
        }
    }
}