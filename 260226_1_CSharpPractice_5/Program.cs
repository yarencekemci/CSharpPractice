namespace _260226_1_CSharpPractice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           while(true)
            {
                Console.WriteLine("Kelime girin / (Programdan cikmak istediginizde 1'e basiniz):");
                string kelime = Console.ReadLine();

                if (kelime == "1")
                    break;

                string tersKelime = KelimeTersCevir(kelime);
                Console.WriteLine("Ters cevrilmis kelime: " + tersKelime);
            }
            Console.WriteLine("Programdan cikiliyor");
            Console.ReadLine();
        }
        static string KelimeTersCevir(string kelime)
        {
            string ters = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                ters += kelime[i]; 
            }

            return ters;
        }
    }
}
