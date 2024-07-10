namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Berkay";
            musteri1.Soyadi = "Tütüncü";
            musteri1.DogumTarihi = new DateTime(2002,05,10);
            musteri1.Meslegi = "Garson";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Selin";
            musteri2.Soyadi = "Çimen";
            musteri2.DogumTarihi = new DateTime(1996, 11, 29);
            musteri2.Meslegi = "Avukat";



            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "İbrahim";
            musteri3.Soyadi = "Denizci";
            musteri3.DogumTarihi = new DateTime(1978, 06, 22);
            musteri3.Meslegi = "Aşçı";


            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Mine";
            musteri4.Soyadi = "Yılmaz";
            musteri4.DogumTarihi = new DateTime(1987, 01, 13);
            musteri4.Meslegi = "Bankacı";



            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Selim";
            musteri5.Soyadi = "Bakırcı";
            musteri5.DogumTarihi = new DateTime(2006, 04, 30);
            musteri5.Meslegi = "Öğrenci";


            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3, musteri4, musteri5 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteriler);
            musteriManager.MusteriGuncelle(musteriler);
            musteriManager.MusteriSil(musteriler);
            musteriManager.MusteriListele(musteriler);
        }
    }
}
