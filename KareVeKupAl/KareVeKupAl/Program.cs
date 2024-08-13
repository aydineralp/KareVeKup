namespace KareVeKupAl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Kullanıcıdan bir sayı girmesini isteriz
                Console.Write("Bir sayı girin: ");
                int number = int.Parse(Console.ReadLine());

                // Sayının karesini hesaplar
                int square = number * number;
                // Sayının küpünü hesaplar
                int cube = number * number * number;

                // Sonuçları ekrana yazdırır
                Console.WriteLine($"Girilen sayının karesi: {square}");
                Console.WriteLine($"Girilen sayının küpü: {cube}");
            }
            catch (FormatException)
            {
                // Eğer geçersiz bir giriş yapılırsa hata mesajı gösterecektie.
                Console.WriteLine("Geçerli bir tamsayı girin!");
            }
        }
    }
}

