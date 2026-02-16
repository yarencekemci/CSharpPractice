namespace _260216_CSharpPractice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metotlar
            //static int,string,double,float,boolen //geri değer döndürür
            //birinci sayi tek sayı mı çift sayı mı
            //büyük sayı döndüren metot

            Console.WriteLine("1. sayı giriniz: ");
            int sayi1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int buyuk = BuyukSayi(sayi1,sayi2);
            Console.WriteLine("girilen sayilardan buyuk olani: "+buyuk);

            //tek mi cift mi? //1
            TekMiCiftMi(sayi1, "birinci ");
            TekMiCiftMi(sayi2, "ikinci ");
            Console.ReadKey();


        }
        static void TekMiCiftMi(int sayi, string hangisi)
        {
            if(sayi%2==0)
                Console.WriteLine(hangisi+"sayi cift");
            else
                Console.WriteLine(hangisi + "sayi tek");
        }
        
        static int BuyukSayi(int a, int b)
        {
            if (a > b)
                return a;
            else if (b > a)
                return b;
            else
            {
                Console.WriteLine("sayilar esittir");
                return a; //sayılar eşit olduğu için a veya b döndürmen fark etmez
            }
                
        }

    }
}
