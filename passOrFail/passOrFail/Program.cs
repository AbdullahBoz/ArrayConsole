using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace passOrFail
{
    internal class Program
    {
        /*
         * Bir öğrenciye ait 3 yazılı ve 2 sözlü notunu bir dizide saklayan
         * bu notların ortalamasını hesaplayan
         * 50'ye eşit yada büyükse ekrana "Geçti" ve ya "Kaldı" yazdıran mini kod.
         */
        static void Main(string[] args)
        {
            ArrayList notes = new ArrayList();
            int nSum = 0;
            double avg = 0;
            for (int number = 1; number <=3; number++)
            {
                Console.WriteLine("{0}. Yazılı notunu giriniz: ", number);
                notes.Add(Console.ReadLine());
            }
            for (int v = 1; v <= 2; v++)
            {
                Console.WriteLine("{0}. Sözlü notunu giriniz: ",v);
                notes.Add(Console.ReadLine());
            }
            Console.WriteLine("Öğrencinin notları: ");
            foreach (object n1 in notes)
            {
                Console.WriteLine(n1);
                nSum = nSum + Convert.ToInt16(n1);
            }
            avg = nSum / (notes.Count);
            Console.WriteLine("*** Öğrenci Ortalaması= {0}",avg);
            if (avg < 0)
                Console.WriteLine("\n--- Dersten Kaldı ---");
            else
                Console.WriteLine("\n--- Dersten Geçti ---");

            Console.ReadKey();
        }
    }
}
