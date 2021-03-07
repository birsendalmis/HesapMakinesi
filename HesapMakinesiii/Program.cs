using System;

namespace HesapMakinesiii
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cikis = false;
            while (cikis == false)
            {
                int sayi1;
                double sayi2;
                double sonuc;
                string islem;
                char cikisYapmak;

                Console.WriteLine("Birinci sayıyı giriniz :");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz :");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İşlemi seçiniz: (+,-,*,/)");
                islem = Console.ReadLine();

                if(islem == "+")
                {
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Sonuç:" + sonuc);
                }
                else if (islem == "-")
                {
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Sonuç:" + sonuc);
                }
                else if (islem == "*")
                {
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Sonuç:" + sonuc);
                }

                else if (islem == "/")
                {
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Sonuç:" + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Sayı Sıfıra Bölünemez. Tanımsızdır.");
                    }


                }
                else
                { Console.WriteLine("Hatalı Seçim Yaptınız!"); }
                


                Console.Write("\n\n\n Çıkış yapmak istiyorsanız lütfen (E/e) tuşlayınız. Devam etmek istiyorsanız herhangi bir tuşlama yapınız :");
                cikisYapmak = Convert.ToChar(Console.ReadLine());
                if (cikisYapmak == 'E' || cikisYapmak == 'e')
                {
                    cikis = true ; return;
                }
                else
                {
                    cikis = false ;
                }

            }
        }
    }
}
