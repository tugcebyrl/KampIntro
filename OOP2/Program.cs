namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Tuğçe";
            musteri1.Soyadi = "Bayırlı";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2= new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "654321";
            musteri2.SirketAdi = "ASD";
            musteri2.VergiNo = "0987654321";

            Musteri musteri3 = new GercekMusteri(); //new --> bellekteki referans numarası
            Musteri musteri4 = new TuzelMusteri(); //new --> bellekteki referans numarası

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}