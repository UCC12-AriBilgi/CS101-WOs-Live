using System.Net.NetworkInformation;

namespace WO04_SifirGireneKadarToplamVeOrtalama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden 0 değeri girinceye kadar girilen sayıların toplamını ve ortalamasını bulan pp.
            int sayi = 0, adet = 0; 
                double toplam = 0;


            Console.WriteLine("Sayıyı giriniz : ");
            sayi=Convert.ToInt32(Console.ReadLine());
            adet++;
            toplam = sayi;

            while(sayi != 0)
            {
                Console.WriteLine("Sayıyı giriniz : ");
                sayi = Convert.ToInt32(Console.ReadLine());

                toplam += sayi;

                if (sayi != 0)
                {
                    adet++;
                }
            }

            Console.WriteLine($"\n\nToplam = {toplam}, Ortalama = {toplam/adet}");

            Console.ReadKey();
        }
    }
}
