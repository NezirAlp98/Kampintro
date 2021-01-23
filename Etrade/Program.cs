using System;

namespace Etrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1=new Product();

            product1.urunAdi = "Samsung";
            product1.Adet = 20;
            product1.Fiyat = 4000;
            product1.Satici = "Nezir";

            Product product2=new Product();
            product2.urunAdi = "IPhone";
            product2.Adet = 10;
            product2.Fiyat = 8000;
            product2.Satici = "Alp";

            Product product3=new Product();
            product3.urunAdi = "Xiaomi";
            product3.Adet = 30;
            product3.Fiyat = 2500;
            product3.Satici = "Mehmet";

            Product[] products = new Product[] {product1, product2, product3};
            
            foreach (var product in products)
            {
                Console.WriteLine("Ürün adı" + " " + product.urunAdi);
                Console.WriteLine("Adet" + " " + product.Adet);
                Console.WriteLine("Ürün fiyatı" + " " + product.Fiyat);
                Console.WriteLine("Ürün satıcısı" + " " + product.Satici);
            }

            Console.WriteLine("foreach sonu");

            Console.WriteLine("*******************");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün adı" + " " + products[i].urunAdi);
                Console.WriteLine("Adet" + " " + products[i].Adet);
                Console.WriteLine("Ürün fiyatı" + " " + products[i].Fiyat);
                Console.WriteLine("Ürün satıcısı" + " " + products[i].Satici);
            }

            Console.WriteLine("for sonu");

            Console.WriteLine("*******************");



            int k = 0;
            while (k<products.Length)
            {
                Console.WriteLine("Ürün adı" + " " + products[k].urunAdi);
                Console.WriteLine("Adet" + " " + products[k].Adet);
                Console.WriteLine("Ürün fiyatı" + " " + products[k].Fiyat);
                Console.WriteLine("Ürün satıcısı" + " " + products[k].Satici);
                k++;
            }

            Console.WriteLine("while sonu");




        }
    }

    class Product
    {
        public string urunAdi { get; set; }
        public int Adet { get; set; }
        public int Fiyat { get; set; }
        public string Satici { get; set; }

    }
}
