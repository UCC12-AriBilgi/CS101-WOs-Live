namespace WO02_UcSayiEnBuyukEnKucukToplamOrtalama
{
    internal class Program
    {
        static int sayi1 = 0, sayi2 = 0, sayi3 = 0;
        static int enbuyuk = 0, enkucuk = 0, ortanca = 0;

        static void Main(string[] args)
        {
            // Ekrandan alınan 3 adet tamsayının en büyüğünü,en küçüğünü,toplamlarını ve ortalamasını bulan pp.


            do
            {
                Console.Clear();

                VeriAl();

                if (sayi1 < sayi2 && sayi1 < sayi3)
                {
                    enkucuk = sayi1;

                    if (sayi2 < sayi3)
                    {
                        enbuyuk = sayi3;

                        ortanca = sayi2;
                    }
                    else
                    {
                        enbuyuk = sayi2;

                        ortanca = sayi3;
                    }
                }
                else if (sayi2 < sayi1 && sayi2 < sayi3)
                {
                    enkucuk = sayi2;

                    if (sayi1 < sayi3)
                    {
                        enbuyuk = sayi3;

                        ortanca = sayi1;
                    }
                    else
                    {
                        enbuyuk = sayi1;

                        ortanca = sayi3;
                    }
                }
                else
                {
                    enkucuk = sayi3;

                    if (sayi1 < sayi2)
                    {
                        enbuyuk = sayi2;

                        ortanca = sayi1;
                    }
                    else
                    {
                        enbuyuk = sayi1;

                        ortanca = sayi2;
                    }
                }

                double toplam = sayi1 + sayi2 + sayi3;
                double ort = toplam / 3;

                Console.WriteLine($"En küçük sayı : {enkucuk}\nOrtanca sayı : {ortanca}\nEn büyük sayı : {enbuyuk}\n\nToplam  : {toplam}\nOrtalama : {ort.ToString()}");



                Console.ReadKey();

            } while (true);





        }

        private static void VeriAl()
        {

            Console.WriteLine("Lütfen 1.sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 2.sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen 3.sayıyı giriniz : ");
            sayi3 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
