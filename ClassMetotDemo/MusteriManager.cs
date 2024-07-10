using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri[] musteriler) 
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri" + " " + musteri.Id + " " + "numarasıyla sisteme eklenmiştir.");
            }
            
        }

        public void MusteriGuncelle(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + "numaralı müşterinin bilgileri güncellenmiştir.");
            }
            
        }


        public void MusteriSil(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + "numaralı müşteri sistemden silinmiştir.");
            }
            
        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.Adi + " - " + musteri.Soyadi + " - " + musteri.DogumTarihi + " - " + musteri.Meslegi);
            }
            
        }
    }
}
