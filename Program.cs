using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kaç Sayı Gireceksiniz.(örn 2 - 3)");
            int kac = Convert.ToInt32(Console.ReadLine());

            if(kac == 2)
            {
                Console.WriteLine("1. Sayı");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayı");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girdiğiniz Sayılar=> " + a + " " + b );
                Console.WriteLine("Çarpımları => " + carpim(a, b));
            }

            else if (kac == 3)
            {
                Console.WriteLine("1. Sayı");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2. Sayı");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("3. Sayı");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girdiğiniz Sayılar=> " + a + " " + b + " " + c );
                Console.WriteLine("Çarpımları => " + carpim(a, b, c) );

            }

            else
            {
                Console.WriteLine("Yanlış Parametre Girdiniz.");
            }


        }

        private static int carpim(int a, int b)

        {
            return a * b;
        }

        private static int carpim(int a, int b , int c)

        {
            return a * b * c;
        }
    }
}
