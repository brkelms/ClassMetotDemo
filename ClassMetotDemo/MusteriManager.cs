using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Adi+ " adlı müşteri eklendi!" );
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Adi + " adlı müşterinin kaydı silindi!");
        }
        public void TelGuncelle(Musteri musteri, int tel)
        {
            Console.WriteLine(" ");
            Console.WriteLine(musteri.Adi + " adlı müşterinin bilgileri güncellendi! Yeni bilgileri aşağıdadır.");
            Console.WriteLine("Müşteri Id: " + musteri.Id);
            Console.WriteLine("Adı: " + musteri.Adi);
            Console.WriteLine("Soyadı: " + musteri.Soyadi);
            Console.WriteLine("Şehri: " + musteri.Sehir);
            Console.WriteLine("Mail: " + musteri.Email);
            Console.WriteLine("Telefon: " + tel + " <= Değiştirildi!");
            Console.WriteLine("Kredi Tercihi: " + musteri.KrediTipi);
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id: "+musteri.Id);
            Console.WriteLine("Adı: " + musteri.Adi);
            Console.WriteLine("Soyadı: " + musteri.Soyadi);
            Console.WriteLine("Şehri: " + musteri.Sehir);
            Console.WriteLine("Mail: " + musteri.Email);
            Console.WriteLine("Telefon: " + musteri.Telefon);
            Console.WriteLine("Kredi Tercihi: " + musteri.KrediTipi);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
