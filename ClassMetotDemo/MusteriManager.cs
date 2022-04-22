using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriSira(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sırasını Aldı." + " " +"Sıra Numarası :" 
              + " " + musteri.Id +" " + musteri.MusteriAdi);

        }

    }
}
