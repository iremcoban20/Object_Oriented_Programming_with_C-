using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi_1 = Convert.ToInt32(Console.ReadLine());

            if (sayi_1 > 0)
            {
                Console.WriteLine($"Girmiş olduğunuz {sayi_1}sayısı pozitif bir sayıdır");
            }
            else if (sayi_1 < 0)
            {
                Console.WriteLine($"girmiş olduğunuz {sayi_1}sayısı negatif bir sayıdır");
            }
            else 
            {
                Console.WriteLine($"Lütfen bir tamsayı giriniz");
            }
            */
            //Console.WriteLine("lütfen bir gün giriniz");
            //string gunler=Console.ReadLine();

            //if (gunler.ToLower() == "pazartesi")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta içidir");
            //}
            //else if (gunler.ToLower()== "salı")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta içidir");
            //}
            //else if (gunler.ToLower() == "çarşamba")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta içidir");
            //}
            //else if (gunler.ToLower() == "perşembe")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta içidir");
            //}
            //else if (gunler.ToLower() == "cuma")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta içidir");
            //}
            //else if (gunler.ToLower() == "cumartesi")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta sonudur");
            //}
            //else if (gunler.ToLower() == "pazar")
            //{
            //    Console.WriteLine($"girdiğiniz {gunler}günü hafta sonudur");
            //}
            //else 
            //{
            //    Console.WriteLine("geçerli bir gün giriniz");
            //} 

            //Console.WriteLine("lütfen bir sayı giriniz");
            //int sayi=Convert.ToInt32(Console.ReadLine());
            //string result = (sayi > 0) ? "pozitif sayı" : "negatif sayı";
            //Console.WriteLine(result);
            //Console.WriteLine("lütfen bir sayı giriniz");
            //string deger = Console.ReadLine();


            //if (int.TryParse(deger, out int number))
            //{
            //    if (number%2== 0)
            //    {
            //        Console.WriteLine($"{number} sayısının karesi ={number * number}");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("lütfen çift sayı giriniz");
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("lütfen int tipinde bir sayı giriniz");
            //}
            
            
            Console.WriteLine("lütfen birinci tamsayıyi giriniz");
            int sayi_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen ikinci tamsayıyi giriniz");
            int sayi_2 = Convert.ToInt32(Console.ReadLine());
            if ((sayi_1 % 2 == 0 ) || (sayi_2 % 2 == 0))
            {
                Console.WriteLine($"iki sayının çarpımı = {sayi_1 * sayi_2}");
            }
            else
            {
                Console.WriteLine("lütfen herhangibirini çift sayı giriniz");
            }



        }
    }
}
