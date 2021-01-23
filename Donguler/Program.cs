using System;
using System.Globalization;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Temel Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            //array dizi
            string[] kurslar=new string[] {"Yazılım Geliştirici Yetiştirme Kampı" ,
                "Temel Başlangıç İçin Temel Kurs",
                "Java","Python","C#"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach sonu");

            int j = 0;
            while (j<kurslar.Length)
            {
                Console.WriteLine(kurslar[j]);
                j++;
            }

           
            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
