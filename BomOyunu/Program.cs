using System;

namespace BomOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom oyununa hoşgeldiniz!");
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Oyun kuralları:\n" +
                "1) Bom olarak girdiğiniz rakamı ve katlarını girmeniz gerektiğinde ekrana \"BOM\" yazmalısınız\n" +
                "2) Sayılar 1'er 1'er artmaktadır\n" +
                "3) Bom sayısı 100'den küçük olmalıdır\n" +
                "4) Oyun 100'de biter\n");
                Console.Write("Bom sayısını giriniz: ");
            int bomSayisi = 1;
            
            bool bError = true;
            do
            {

                try
                {
                    bomSayisi = Convert.ToInt32(Console.ReadLine());
                    if (bomSayisi >= 100 || bomSayisi < 1)
                    {
                        throw new Exception(message: "Sayı 1 ile 100 arasında değil");
                    }
                    bError = false;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (bError);

            bool kontrol = true;
            
                for (int i = 1; i < 100; i += 2)
                {
                    int kullaniciNumarasi = 1;

                    if (i % bomSayisi == 0)
                    {
                        Console.WriteLine("Bom");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }

                    if (((i + 1) % bomSayisi) != 0)
                    {
                        try
                        {
                            kullaniciNumarasi = Convert.ToInt32(Console.ReadLine());
                            if (kullaniciNumarasi != (i + 1))
                            {
                                throw new Exception(message: "Kaybettiniz\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            kontrol = false;
                            break;
                        }
                    }
                    else
                    {
                        string bomKontrol = Console.ReadLine();
                        if ((bomKontrol != "BOM") && (bomKontrol != "bom"))
                        {
                            Console.WriteLine("Kaybettiniz\n");
                            kontrol = false;
                            break;
                        }
                    }

                }
                if (kontrol)
                {
                    Console.WriteLine("Kazandınız");
                }

                Console.Write("Tekrar oynamak ister misiniz? (Evet ise 'E' ye basınız): ");
                key = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
            }
            while (key.Key == ConsoleKey.E);
        }
    }
}
