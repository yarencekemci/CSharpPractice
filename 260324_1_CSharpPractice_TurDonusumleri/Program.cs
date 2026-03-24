namespace _260324_1_CSharpPractice_TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Yaren";
            string strNum = "35";
            int sayi = 10;
            double sayi2 = 10.5;

            Console.WriteLine(ad + " " + ad.GetType());
            Console.WriteLine(sayi + " " + sayi.GetType());
            Console.WriteLine(sayi2 + " " + sayi2.GetType());
            Console.WriteLine(strNum + " " + strNum.GetType()); // 35 -> system.string veriyor

            Console.WriteLine("--- Int To String ---");
            string yeniDeger = Convert.ToString(sayi);

            Console.WriteLine(yeniDeger + " " + yeniDeger.GetType());

            Console.WriteLine("--- String to Int ---");
            int yeniSayi = Convert.ToInt32(strNum);
            Console.WriteLine(yeniSayi + " " + yeniSayi.GetType());

            Console.Read();

            //Parse : Tür dönüşümü için kullanılır
            string sayi3 = "5";
            Console.WriteLine(sayi3 + " " + sayi3.GetType());

            Console.WriteLine("Star to Int");

            int yeniSayi2 = int.Parse(sayi3);
            Console.WriteLine(yeniSayi2 + " " + yeniSayi2.GetType());


            Console.Read();

        }
    }
}
