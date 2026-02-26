namespace _260226_1_CSharpPractice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı gir: ");
            int s1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı gir: ");
            int s2 = int.Parse(Console.ReadLine());

            ToplamYazdir(s1, s2);
            CarpimYazdir(s1, s2);

            Console.ReadLine();
        }
        static void ToplamYazdir(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("Toplamları: "+toplam);
        }
        static void CarpimYazdir(int s1, int s2)
        {
            int carpim = s1 * s2;
            Console.WriteLine("Çarpım: " + carpim);
        }
    }
}
