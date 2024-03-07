namespace WO05_NAdetSayininKarelerininToplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden okunacak N adet sayinin karelerinin toplamı 
            // for ile yapılabilir..
            int adet = 0, sayi=0;
            double toplam = 0;

            Console.Write("Kaç adet sayı gireceksin : ");
            adet=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= adet; i++)
            {
                Console.Write($"{i}.sayıyı giriniz : ");
                sayi=Convert.ToInt32(Console.ReadLine());

                toplam += Math.Pow(sayi, 123);
            }

            Console.WriteLine($"Girilen sayıların karelerinin/küp toplamı = {toplam} ");





            Console.ReadKey();
        }
    }
}
