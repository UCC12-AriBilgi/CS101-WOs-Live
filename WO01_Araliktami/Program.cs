namespace WO01_Araliktami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen bir sayının 0-100 arasında olup olmadığını gösteren (arasında veya arasında değil seklinde gösteren program parçasını yazınız.
            int sayi = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("Lütfen sayınızı giriniz..");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi >= 0 && sayi <= 100)
                {
                    Console.WriteLine($"Girmiş olduğunuz {sayi} 0-100 arasındadır..");
                }
                else
                {
                    Console.WriteLine($"Girmiş olduğunuz {sayi} 0-100 arasında değildir..");
                }
                
                Console.ReadKey();
            
            } while (true);

        }
    }
}
