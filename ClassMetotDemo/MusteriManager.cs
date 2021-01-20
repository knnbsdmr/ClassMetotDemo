using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} {1} müşterisi eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} {1} müşterisi silindi."); 
        }
    }
}
