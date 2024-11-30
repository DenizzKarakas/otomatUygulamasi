using System.ComponentModel.Design;
using System.Diagnostics;

namespace otomatUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YANLIŞİŞLEM:
            string[] eklenenUrunler = { };
            double[] eklenenUrunlerFiyat = { };
            ANASAYFA:
            Console.WriteLine("Alışverişe Başlamak İçin = 1'e Basınız");
            Console.WriteLine("Admin Panel İçin = 0'a Basınız");
            int secenek = Convert.ToInt32(Console.ReadLine());
            

            if (secenek == 1)
            {
                string[] ürünler = { "Kola", "Fanta", "Çikolata" };
                double[] fiyatlar = { 40, 40, 30 };

                if (eklenenUrunler.Length != 0)
                {
                   ürünler = eklenenUrunler.Concat(ürünler).ToArray();
                   fiyatlar = eklenenUrunlerFiyat.Concat(fiyatlar).ToArray();
                }

                double cuzdan = 0;
                while (true)
                {
                    for (int i = 0; i < ürünler.Length; i++)
                    {
                        Console.WriteLine($"{i}-{ürünler[i]}:{fiyatlar[i]}");
                    }
                    Console.WriteLine("İstenilen Ürün Numarası:");
                    int ürün = Convert.ToInt32(Console.ReadLine());


                    if (ürün >= 0 && ürün < fiyatlar.Length)
                    {
                        while (true)
                        {
                            Console.WriteLine("Para Girişi:");
                            cuzdan += Convert.ToDouble(Console.ReadLine());

                            if (cuzdan >= fiyatlar[ürün])
                            {
                                if (cuzdan > fiyatlar[ürün])
                                {
                                    Console.WriteLine((cuzdan - fiyatlar[ürün]) + "TL Para Üstünüzü Alınız");
                                    cuzdan = 0;
                                    break;
                                }
                                else { Console.WriteLine("Afiyet Olsun"); break; }

                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye");
                                Console.WriteLine("1-Para Ekle \n2-Para İade");
                                int islem = Convert.ToInt32(Console.ReadLine());
                                if (islem == 1)
                                {
                                    continue;
                                }
                                else if (islem == 2)
                                {
                                    Console.WriteLine(cuzdan + "TL İadeniz Başarılı");
                                    cuzdan = 0;
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Ürün Seçimi Lütfen Geçerli Bir Seçim Yapınız");
                    }
                }
            }
            else if (secenek == 0)
            {
                Console.WriteLine("Admin Paneli");
                Console.WriteLine("Yeni ürün eklemek için = 1");
                Console.WriteLine("Ürün Güncellemek için = 2");
                Console.WriteLine("Ürün Silmek için = 3");
                Console.WriteLine("Ürünleri Listelemek için = 4");
                Console.WriteLine("Gün sonu toplam satış için = 5");
                int adminPanel = Convert.ToInt32(Console.ReadLine());

                switch (adminPanel)
                {
                    case 1:
                        Console.WriteLine("Yeni Ürün Eklenecek");
                        Console.WriteLine("Kaç adet ürün ekleyeceksiniz");
                        int urunSayisi = Convert.ToInt32(Console.ReadLine());
                        Array.Resize(ref eklenenUrunler, urunSayisi);
                        Array.Resize(ref eklenenUrunlerFiyat, urunSayisi);

                        for (int i = 0; i < urunSayisi; i++)
                        {
                            Console.WriteLine("Ürün Adı Giriniz");
                            string yeniUrunAdi = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı Giriniz");
                            double yeniUrunFiyati = Convert.ToDouble(Console.ReadLine());
                            eklenenUrunler[i] = yeniUrunAdi;
                            eklenenUrunlerFiyat[i] = yeniUrunFiyati;
                        }

                        goto ANASAYFA;
                    case 2:
                        Console.WriteLine("Ürünler Güncellenecek");
                        // ürün güncelleme işlemi yazılacak 
                        break;
                    case 3:
                        Console.WriteLine("Ürün Silme");
                        // ürün silme işlemi yazılacak
                        break;
                    case 4:
                        Console.WriteLine("Ürün Listeleme");
                        // ürün listeleme işlemi yazılacak 
                        break;
                    case 5:
                        Console.WriteLine("Gün Sonu Toplam Satış");
                        // gün sonu toplam satış işlemi yazılacak 
                        break;
                    default:
                        Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                        // geçersiz işlem kodu yazılacak
                        break;

                }
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir İşlem Seçiniz");
                goto YANLIŞİŞLEM;
            }
        }
    }

}
