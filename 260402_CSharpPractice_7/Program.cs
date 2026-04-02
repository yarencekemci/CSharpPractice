using System.Runtime.InteropServices;

namespace _260402_CSharpPractice_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan kullanıcı adı ve şifre alın. Eğer kullanıcı adı '' admin '' şifre ''123'' ise
            // Ekrana true/false yazdırın.

            string kullaniciAdi;
            string sifre;

            Console.WriteLine("kullanici adi giriniz: ");
            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("sifre giriniz: ");
            sifre = Console.ReadLine();

            bool kontrol = kullaniciAdi == "admin" && sifre == "123";
            
            Console.WriteLine("bilgileriniz dogru mu? " + kontrol);


        }
    }
}
