using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 100 arası 3 e bölünen sayılar
            //int sayac = 1;
            //while( sayac<101)
            //{
            //    if (sayac % 3 == 0)
            //    {
            //        Console.WriteLine($"sayacta 3'e tam bölünen sayılar= {sayac}");

            //    }
            //    sayac = sayac + 1;
            //}

            //int sayi2 = 3;
            //while (sayi2 < 100)
            //{
            //    Console.WriteLine($"3 e bölünen sayılar={sayi2}");
            //    sayi2=sayi2 + 3;
            //int sayac = 0;
            //for (int i = 2; i < 11; i+=2)
            //{

            //    Console.WriteLine($"sayi={i}");
            //    sayac++;
            //}
            //if (sayac % 2 == 0)
            //{
            //    Console.WriteLine($"sayac= {sayac} ve çift bir sayıdır");
            //}
            //else 
            //{
            //    Console.WriteLine($"Sayac {sayac} ve tek bir sayıdır");
            //}
            //Console.ReadLine();
            //
            // 1-500 arası 3 4 5 e tam bölünen 8 e tam bölünemeyen sayılar

            //int sayi = 0;
            //int sayac= 0;

            //while (sayi < 501)
            //{
            //    if (sayi % 3 == 0 && sayi % 4 == 0 && sayi % 5 == 0 && sayi % 8 != 0)
            //    {
            //        Console.WriteLine($"3'e, 4'e ve 5'e tam bölünen ama 8'e tam bölünemeyen tam sayılar = {sayi}");
            //        sayac = sayac + 1;
            //    }
            //    sayi = sayi + 1;
            //}
            //Console.WriteLine($"{sayac} adet sayı bulundu");
            //int sayi_4 = 3*4*5;
            //int sayac_3 = 0;
            //while (sayi_4 < 501)
            //{
            //    Console.WriteLine($"Sayı = {sayi_4}");
            //    // sonra da artış miktarını bulup bu şekilde
            //    // artmasını sağlıyoruz
            //    sayi_4 = sayi_4 + 120;
            //    sayac_3++;
            //}
            //Console.WriteLine($"{sayac_3} adet sayı bulundu");

            // 1'den 10'a kadar sayıları yazdıran for döngüsü
            //int sayac = 0;
            //for (int i = 0; i < 11; i++) 
            //{ 
            //    Console.WriteLine(i);
            //    sayac++;
            //}
            // 1'den 10'a kadar olan çift sayıları yazdıran for döngüsü

            //int sayac = 0;
            //for (int i = 0; i < 11; i += 2)
            //{
            //    Console.WriteLine($"Çift olan Sayılar = {i}");
            //    sayac++;
            //}

            //string sonuc = sayac % 2 == 0 ? $"sayaç = {sayac}-Çift" : $"sayaç = {sayac}-Tek";
            //if (sayac % 2 == 0)
            //{
            //    Console.WriteLine($"Sayaç = {sayac} ve çift bir sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine($"Sayaç = {sayac} ve tek bir sayıdır");
            //}
            //Console.WriteLine(sonuc);


            string[] haftanin_gunleri = new string[7];
            string[] haftanin_gunleri2;
            haftanin_gunleri2 = new string[7];
            haftanin_gunleri2[0] = "pazartesi";
            haftanin_gunleri2[1] = "salı";
            haftanin_gunleri2[2] = "çarşamba";
            haftanin_gunleri2[3] = "perşembe";
            haftanin_gunleri2[4] = "cuma";
            haftanin_gunleri2[5] = "cumartesi";
            haftanin_gunleri2[6] = "pazar";

            string[] haftanin_gunleri3 = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };

            //for (int i = 0; i < haftanin_gunleri2.Length; i++)
            //{
            //    Console.WriteLine($"dizinin {i + 1}   elemanı = {haftanin_gunleri2[i]}");
            //}
            //Console.ReadLine();

            //for (int i = 0; i <haftanin_gunleri2.Length; i++) 
            //{
            //    if (i==5 | i==6)
            //    {
            //        continue;
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"Dizinin {i + 1} elemanı = {haftanin_gunleri2[i]}");
            //    }
            //}
            //for (int i = 0; i < haftanin_gunleri2.Length; i++)
            //{
            //    if (haftanin_gunleri2[i] == "cumartesi" | haftanin_gunleri2[i] == "pazar")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Dizinin {i + 1}. elemanı = {haftanin_gunleri2[i]}");
            //    }

            //}
            //Console.WriteLine("-----------------------------------");
            //Array.Reverse(haftanin_gunleri2 );
            //for (int i = 0; i < haftanin_gunleri2.Length; i++) 
            //{
            //    Console.WriteLine(haftanin_gunleri2[i]);
            //}
            //Console.WriteLine(Array.IndexOf(haftanin_gunleri2,"pazartesi"));
            //Console.WriteLine(haftanin_gunleri2.Contains("pazar"));


            foreach (var item in haftanin_gunleri2)
            {
                Console.WriteLine(item);
            }
        }



    }
}      