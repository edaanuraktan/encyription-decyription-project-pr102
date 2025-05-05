using System;
using System.Text;

namespace Task3Programming101
{
    class Program
    {
        static string Sifrele(string metin)
        {
            if (string.IsNullOrEmpty(metin))
                return string.Empty;

            byte[] asciiDegerler = Encoding.ASCII.GetBytes(metin);

            for (int i = 0; i < asciiDegerler.Length; i++)
            {
                asciiDegerler[i] += 1;
            }

            return Encoding.ASCII.GetString(asciiDegerler);
        }

        static string SifreCoz(string sifreliMetin)
        {
            if (string.IsNullOrEmpty(sifreliMetin))
                return string.Empty;

            byte[] asciiDegerler = Encoding.ASCII.GetBytes(sifreliMetin);

            for (int i = 0; i < asciiDegerler.Length; i++)
            {
                asciiDegerler[i] -= 1;
            }

            return Encoding.ASCII.GetString(asciiDegerler);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Şifrelemek istediğiniz metni giriniz: ");
                string giris = Console.ReadLine();

                string sifreli = Sifrele(giris);
                string cozulmus = SifreCoz(sifreli);

                Console.WriteLine($"\nŞifrelenmiş Hali: {sifreli}");
                Console.WriteLine($"Çözülmüş Hali  : {cozulmus}\n");

                string devam;

                // Kullanıcı doğru cevap verene kadar sor
                while (true)
                {
                    Console.Write("Yeni bir metin şifrelemek ister misiniz? (e/h): ");
                    devam = Console.ReadLine()?.Trim().ToLower();

                    if (devam == "e" || devam == "h")
                        break;

                    Console.WriteLine("Hatalı giriş! Lütfen sadece 'e' veya 'h' giriniz.\n");
                }

                if (devam == "h")
                    break;

                Console.WriteLine();
            }
        }
    }
}