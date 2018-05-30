using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc = 1;
            Console.Write("Karekökü hesaplanacak sayıyı girip enter tuşuna basınız :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double karekok(double kok)
            {
                double kokSonuc = (kok + sayi / kok) / 2;
                return kokSonuc;
            }
            for (int i = 0; i < 5; i++)
            {
                sonuc = karekok(sonuc);
                Console.WriteLine("X{0} = " +sonuc.ToString(),i);
            }
            Console.ReadKey();
        }
    }
}
