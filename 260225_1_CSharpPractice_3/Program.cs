using System;
using System.Collections.Generic;

namespace _260225_1_CSharpPractice_3
{
    internal class Program
    {
        static List<int> notlar = new List<int>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Not giriniz (cikmak icin -1): "); // -1 yazana kadar not ister

                try
                {
                    int girilenNot = Convert.ToInt32(Console.ReadLine());

                    if (girilenNot == -1)
                    {
                        break;  // Döngüden çık
                    }

                    NotEkle(girilenNot);
                }
                catch
                {
                    Console.WriteLine("Lutfen gecerli sayi giriniz!");
                }
            }

            DurumGoster();
            Console.ReadLine();
        }

        static void NotEkle(int not)
        {
            if (not < 0 || not > 100)
            {
                Console.WriteLine("Gecersiz not (0-100 arasi olmali)");
                return;
            }
            notlar.Add(not);
            Console.WriteLine("Not eklendi");
        }

        static double OrtalamaHesapla()
        {
            int toplam = 0;
            foreach (int n in notlar)
                toplam += n;
            return (double)toplam / notlar.Count;
        }

        static void DurumGoster()
        {
            if (notlar.Count == 0)
            {
                Console.WriteLine("Hic not girilmedi");
                return;
            }

            double ortalama = OrtalamaHesapla();

            if (ortalama >= 50)
                Console.WriteLine($"Ortalama: {ortalama} - gecti");
            else
                Console.WriteLine($"Ortalama: {ortalama} - kaldi");
        }
    }
}