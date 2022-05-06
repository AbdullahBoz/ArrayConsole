using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saveInformation
{
    internal class Program
    {
        // Girilen bilgileri dizide kaydeden ve daha sonra bilgileri çağırabileceğiniz mini kod.
        static void Main(string[] args)
        {
            Console.WriteLine("Adres defterine girmek istediğiniz kayıt sayısını giriniz: ");
            int snumber = Convert.ToInt16(Console.ReadLine());
            string[] names = new string[snumber];
            string[] address = new string[snumber];  
            string[] phone= new string[snumber];
            for (int i = 0; i < snumber; i++)
            {
                Console.WriteLine("{0}. İsim ve soyisim giriniz: ",i+1);
                names[i] = (Console.ReadLine());  
                Console.WriteLine("{0}. Adres giriniz: ",i+1);
                address[i] = (Console.ReadLine());
                Console.WriteLine("{0}. Telefon numarası giriniz: ",i+1);
                phone[i] = (Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Aramak istediğiniz isim soyismi giriniz: ");
            string search = Console.ReadLine();
            int index = Array.IndexOf(names, search);
            if (index == -1)
                Console.WriteLine("Aradığınız Kayıt Bulunamadı...");
            else
            {
                Console.WriteLine("Aradığınız kayıt Telefon numarası = "+phone[index]);
                Console.WriteLine("Aradığınız kayıt Adresi = "+address[index]);
            }
            Console.ReadKey();
        }
    }
}
