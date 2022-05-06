using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentWeights
{
    internal class Program
    {
        // Bir sınıftaki 5 öğrencinin ağırlıklarının tutulduğu bir dizi oluşturan
        // ortalama ağırlığı bulan mini kod.
        static void Main(string[] args)
        {
            int[] weights = new int[5];
            int w = 0, avg;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. Öğrenci ağırlığını giriniz: ", (i+1));
                weights[i] = Convert.ToInt16(Console.ReadLine());
                w= w + weights[i];
            }
            avg = w / 5;
            Console.WriteLine("Sınıfın toplam ağırlığı = {0}", w);
            Console.WriteLine("\nSınıfın ağırlık ortalaması = {0}", avg);
            for (int s = 0; s < 5; s++)
            {
                Console.WriteLine("* Öğrenci: {0} Ağırlığı: {1}",(s+1), weights[s]);
            }
            Console.ReadKey();
        }
    }
}
