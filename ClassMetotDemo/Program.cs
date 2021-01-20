using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Adi = "Kenan",
                Soyadi = "Başdemir",
                Yasi = 19
            };

            Musteri musteri2 = new Musteri()
            {
                Adi = "Mehmet",
                Soyadi = "Demir",
                Yasi = 22
            };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Sil(musteri1);
        }
    }
}
