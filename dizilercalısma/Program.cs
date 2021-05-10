using System;

namespace dizilercalısma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[17];
            int max;
            for(int i = 0; i < 17; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = a[0];
            for (int i = 1 ; i < 17; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("En Büyük Sayı : {0}",max);
        }

    }
}
