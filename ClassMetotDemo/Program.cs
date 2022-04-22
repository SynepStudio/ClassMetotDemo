using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Selim";
            musteri1.MusteriSoyAdi = "Uçar";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Fatih";
            musteri2.MusteriSoyAdi = "Gökçe";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Ayşe";
            musteri3.MusteriSoyAdi = "Azat";

            Musteri[] musteri = new Musteri[] {musteri1,musteri2,musteri3 };

            foreach (var Musteri in musteri)
            {
                Console.WriteLine(Musteri.Id);
                Console.WriteLine(Musteri.MusteriAdi);
                Console.WriteLine(Musteri.MusteriSoyAdi);
                Console.WriteLine("-------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriSira(musteri1);
            musteriManager.MusteriSira(musteri2);
            musteriManager.MusteriSira(musteri3);
        }
    }
}
