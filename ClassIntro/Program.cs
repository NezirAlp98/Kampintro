using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2=new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Nezir Alp Arslan";
            kurs2.izlenmeOrani = 85;

            Kurs kurs3=new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Murat Kurtboğan";
            kurs3.izlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi +  " "  + kurs1.Egitmen  );
            Kurs[] kurslar=new Kurs[] {kurs1,kurs2,kurs3};
            
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
