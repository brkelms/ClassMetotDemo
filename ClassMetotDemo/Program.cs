using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //BİRİNCİ MÜŞTERİ
            Musteri musteri1 = new Musteri();
            musteri1.Id = 190567092;
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Elmas";
            musteri1.Sehir = "Tekirdağ";
            musteri1.Email = "burakburak6@gmail.com";
            musteri1.Telefon = 0549890601;
            musteri1.KrediTipi = "Öğrenim Kredisi";
            //İKİNCİ MÜŞTERİ
            Musteri musteri2 = new Musteri();
            musteri2.Id = 993567400;
            musteri2.Adi = "Elif";
            musteri2.Soyadi = "Korkmaz";
            musteri2.Sehir = "İstanbul";
            musteri2.Email = "elifelif1@gmail.com";
            musteri2.Telefon = 0549890999;
            musteri2.KrediTipi = "İhtiyaç Kredisi";
            //ÜÇÜNCÜ MÜŞTERİ
            Musteri musteri3 = new Musteri();
            musteri3.Id = 510787099;
            musteri3.Adi = "Muhammed";
            musteri3.Soyadi = "İnan";
            musteri3.Sehir = "Çanakkale";
            musteri3.Email = "mamimami81@gmail.com";
            musteri3.Telefon = 0549890221;
            musteri3.KrediTipi = "Konut Kredisi";
            //MÜŞTERİLER DİZİYE EKLENİYOR
            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            Console.WriteLine("********Müşteri Bilgileri Listesi********");
            foreach (var customer in Musteriler)
            {
                MusteriManager musteriManager = new MusteriManager();
                musteriManager.Listeleme(customer);

            }

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri2);
            musteriManager1.Sil(musteri3);
            musteriManager1.TelGuncelle(musteri1, 0519899651);

            Console.ReadLine();



        }
    }
}
