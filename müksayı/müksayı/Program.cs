using System;

namespace müksayı
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi;
           
            int toplam = 0;
            for (int i = 1; i <= sayi / 2; i++)
            {

                if (sayi % i == 0)
                {
                    toplam = toplam + i;
                }
            }
            if (sayi == toplam)
            {
              Console.Write("Girdiğiniz Sayı Bir Mükemmel Sayıdır");
            }
            else
            {
               Console.Write("Girdiğiniz Sayı Bir Mükemmel Sayı Değildir");
            }

        }

    }
    }

