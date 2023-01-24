using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geçme_notu_yazdırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.Notunuzu Giriniz");
            int birinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Notunuzu Giriniz");
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 3.Notuuzu Giriniz");
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;
            if (sonuc >= 80 && sonuc < 100)
            {
                Console.WriteLine("Not Değerinz A+");
                Console.ReadLine();
            }
            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("Not Değeriniz A");
                Console.ReadLine();

            }
            else if (sonuc>40 && sonuc<60)
            {
                Console.WriteLine("Not Değeriniz B+");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Not Değeriniz F");
                Console.ReadLine();
            }
           
        }
    }
}
