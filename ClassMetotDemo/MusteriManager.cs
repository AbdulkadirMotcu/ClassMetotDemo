using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {

            Console.WriteLine("Kullanıcı Eklendi : " + musteri.Ad);
            
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Kullanıcı Silindi : " + musteri.Ad);
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(" AD : " + musteri.Ad);
            Console.WriteLine(" Soyad : " + musteri.Soyad);
            Console.WriteLine(" Tc : " + musteri.Tc);
            Console.WriteLine(" İban " + musteri.Iban);
        }
    }
}
