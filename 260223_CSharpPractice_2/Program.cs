using System;
using System.Collections.Generic;

namespace _260223_CSharpPractice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // müzik dinleme programında 
            /*
            şarkı ekle
            şarkıları listele
            random şarkı çal
            çıkış
            */

            List<string> sarkilar = new List<string>();
            Random random = new Random();
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Merhaba");
                Console.WriteLine("1 - Şarkı ekle");
                Console.WriteLine("2 - Şarkıları listele");
                Console.WriteLine("3 - Random Şarkı Çal");
                Console.WriteLine("0 - Çıkış");
                Console.WriteLine("Seçiminiz: ");

                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.Write("Şarkı adı: ");
                        string sarkiAdi = Console.ReadLine();
                        if (sarkilar.Contains(sarkiAdi))
                            { Console.WriteLine("Bu şarkı zaten listede");  }
                        else
                        {
                            sarkilar.Add(sarkiAdi);
                            Console.WriteLine("Şarkı eklendi");
                        }
                            break;
                    case "2":
                        if (sarkilar.Count == 0)
                        {
                            Console.WriteLine("Henüz şarkı eklenmedi");
                        }
                        Console.WriteLine("Şarkı listesi: ");
                        foreach (string sarki in sarkilar)
                            Console.WriteLine(" - " + sarki);
                        break;
                    case "3":
                        if (sarkilar.Count == 0)
                            Console.WriteLine("Random çalmak için şarkı ekleyiniz");
                        else
                        {
                            int index = random.Next(sarkilar.Count);
                            Console.WriteLine("Şu an çalıyor " + sarkilar[index]);
                        }
                        Bekle();
                            break;
                    case "0":
                        devam = false;
                        Console.WriteLine("Çıkış yapılıyor.");
                        
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız");
                        Bekle();
                        break;
                }

            }
        }
        static void Bekle()
        {
            Console.WriteLine();
            Console.WriteLine("Devam etmek için herhangi bir tuşa basın.");
            Console.ReadKey();
        }
    }

}
