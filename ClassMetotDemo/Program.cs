using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Kadir";
            musteri1.Soyad = "Motcu";
            musteri1.Tc = "12345678900";
            musteri1.Iban = "1234567891234567";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Damla";
            musteri2.Soyad = "Bilmem";
            musteri2.Tc = "98765432100";
            musteri2.Iban = "0000000123456789";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Adı : " + musteri.Ad);
                Console.WriteLine("Soyad : " + musteri.Soyad);
                Console.WriteLine("Iban : " + musteri.Iban);
                Console.WriteLine(" ");
            }

            Console.WriteLine("------------Metotlar-------------");

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("-----------Müşreti Ekle---------------");
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("-----------Müşreti Sil---------------");
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("-----------Müşreti Listele---------------");
            musteriManager.MusteriListele(musteri1);


        }
    }
}
