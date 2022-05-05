using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storePrice
{
    internal class Program
    {
        /* DİZİ - ARRAY.
             * Bir mağazadaki ürünlerin fiyatlarını bir dizide tutacağız
             * ürünün fiyatı 200 tl'den fazla ise %30
             * 200 tl'den az ise %15 indirim uygulayacağız.
             * Ürünlerin Normal ve İndirimli fiyatlarını yazan mini program yapacağız.
             */
        static void Main(string[] args)
        {
            int size; // dizi boyutu için değişken tanımladık.
            Console.WriteLine("Enter Array size: ");
            size = Convert.ToInt16(Console.ReadLine());
            double[] price = new double[size]; // Dizimizin boyutunu kullanıcının girdiği boyuta tanımlıyoruz.
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0}, Enter the price of the product: ",(i+1)); //işlemler parantez içinde yapılıyor.
                price[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Normal price: ");
            foreach (double p2 in price)     // dizilerin içinde foreach döngüsü ile dolaşıyoruz.
                Console.Write(p2 + "-");
            Console.WriteLine("\n\n************* Discount Price *************");
            foreach (double p1 in price)
            {
                if (p1 >= 200)
                    Console.WriteLine((p1 * 0.7)); // %30 luk işlem
                else
                    Console.WriteLine((p1 * 0.8)); // %20 lik işlem
            }
            Console.ReadKey();
        }
    }
}
