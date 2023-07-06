namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type safety
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");

            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
        }
    }
}