using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  string name = "İrem";
              string surname = "Çoban";
              int age = 20;
              Console.WriteLine($"{name},{surname} ,{age} yasındadır");

              Console.WriteLine("Lütfen kullanıcı adınızı girin:");
              string username=Console.ReadLine();

              Console.WriteLine("Lütfen soyadınızı girim :");
              string user_surname=Console.ReadLine();

              Console.WriteLine($"Hoşgeldiniz Sayın {username} {user_surname}");
              Console.ReadLine();

              Console.Write("1. sayıyı giriniz =");
              int num_1= Convert.ToInt32( Console.ReadLine());

              Console.Write("2. sayıyı giriniz =");
              int num_2= Convert.ToInt32( Console.ReadLine());

              Console.WriteLine($"Toplama işleminin sonucu = {num_1+num_2}");
              Console.WriteLine($"Çıkarma işleminin sonucu = {num_1-num_2}");
              Console.WriteLine($"Çarpma işleminin sonucu = {num_1*num_2}");

              double bolme = (double)num_1 / num_2;
              Console.WriteLine($"Bölme işleminin sonucu= {bolme:0.00}");
               */

            string cumle = "Burdur Mehmet Akif Ersoy Üniversitesi";
            Console.WriteLine($"Girdiğiniz cumle={cumle}");
            Console.WriteLine($"Cümlenin Uzunluğu = {cumle.Length}");
           
            Console.WriteLine($"Cümlenin içinde Z harfi var mı? {cumle.Contains('Z')}");
            Console.WriteLine($"Cümlede ur ifaedsi var mı?{cumle.Contains("ur")}");

            Console.WriteLine($"cümlenin büyük harfle yazılışı={cumle.ToUpper()}");
            Console.WriteLine($"Cümlenin küçük harfle yazılışı= {cumle.ToLower()}");

            Console.WriteLine($"{cumle.Replace("Üniversitesi","Üni")}");

            Console.WriteLine(cumle);
            string[] dizi=cumle.Split(' ');
            Console.WriteLine(dizi[0]);

            Console.WriteLine($"Cümle B harfi ile mi başlıyor? Cevap={ cumle.StartsWith("B")}");
            Console.WriteLine($"Cümle Z harfi ile mi bitiyor? Cevap = {cumle.EndsWith("Z")}");

            Console.WriteLine($"Cümlenin ilk harfi= {cumle[0]}");
            Console.WriteLine($"Cümlenin son harfi= {cumle[cumle.Length-1]}");

            string deneme_isim = "irem";
            string deneme_soyisim = "Çoban";
     
            Console.WriteLine($" stringli ifadelerde toplama{deneme_isim + deneme_soyisim}");


            Console.WriteLine(cumle.Substring(5,13));
            Console.ReadLine();





        }
    }
}
