using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıç Sayısını Girinz:");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Son Sayıyı Girinz:");

            int b = Convert.ToInt32(Console.ReadLine());


            int v = ders(a, b);

            for (int f = v; f <= b; f = 5 + f)
            {
                Console.Write (f + " ");
            }

        }

        public static int ders(int a, int b)
        {
            int c = 0;

            for (int i = a; i <= b; i += 1)
            {
                if (i % 5 == 0)
                {
                    c = i;
                }
                break;
            }
            return c;

        }
    }
}
