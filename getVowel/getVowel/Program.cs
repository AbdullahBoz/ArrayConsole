using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getVowel
{
    internal class Program
    {
        // Kullanıcıdan alınan metnin içindeki sesli harflerin sayısını bulan mini kod
        static void Main(string[] args)
        {
            char[] letters = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' }; // Sesli harfler dizimizi tanımlıyoruz.
            string text; // string metin değişkeni oluşturuyoruz.
            int counter = 0; // sayac değişkeni oluşturup 0'a eşitliyoruz.
            Console.WriteLine("Enter text: ");
            text = Console.ReadLine();
            for (int i = 0; i < letters.Length; i++) //döngümüz ile harfler dizimizin içinde dolaşıyoruz.
            {
                for (int j = 0; j < text.Length; j++) 
                {
                    if(text[j] == letters[i]) // metin içinde sesli harf var ise
                        counter++;            // sayacımız'a 1 ekliyoruz.
                }
            }
            Console.WriteLine(counter); //sayacımızı ekrana yazdırıyoruz.
            Console.ReadKey();
        }
        
    }
}
