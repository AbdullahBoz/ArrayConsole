using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumbers
{
    internal class Program
    {
        // 10 Elemanlı dizinin içerisine for döngüsü ile rastgele 1-500 arası sayılar atarak ekranda görüntüleyen mini kod.
        static void Main(string[] args)
        {
            int[] array = new int[10]; // 10 elemanlı dizimizi tanımlıyoruz.
            Random rnd = new Random(); // random komutumuzu tanımlıyoruz.
            for (int i = 0; i < 10; i++) 
            {
                array[i] = rnd.Next(1, 500); // rnd.Next(); ile kaçla kaç arasında sayı üretilecek onu belirtiyoruz.
                Console.WriteLine("{0}. Element of array = {1}",i,array[i]); // ekrana yazdırıyoruz.
            }
            Console.ReadKey();
        }
    }
}
