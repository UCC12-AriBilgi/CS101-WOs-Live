namespace WO03_Girilen20YasIcindenAraliktakiniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan 20 tane yaş bilgisi gireceğim
            // Bunlardan 25-45 yaş arası kaç personel olduğunu bulan pp.

            // Burada iki farklı kullanım olabilir (for/while)

            int yas = 0, adet = 0;

            // for ile
            for (int i1 = 1 ; i1 <=10 ; i1++)
            {
                Console.Write($"{i1}.yaşı giriniz : ");
                yas=Convert.ToInt32(Console.ReadLine());

                if (yas >= 25 && yas <= 33)
                {
                    adet++;
                }
            }

            SonucYaz(adet);


            // while ile

            int i = 1;
            adet = 0; // ilk haline getir

            while (i <= 10 )
            {
                Console.Write($"{i}.yaşı giriniz : ");
                yas = Convert.ToInt32(Console.ReadLine());

                if (yas >= 25 && yas <= 33)
                {
                    adet++;
                }

                i++;
            }

            SonucYaz(adet);



            Console.ReadKey();
        }

        #region Methods

        private static void SonucYaz(int pAdet)
        {
            Console.WriteLine($"25-33 yaş aralığında {pAdet} personel vardır. ");
        }


        #endregion
    }
}
