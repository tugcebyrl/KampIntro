namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interface onu implement eden class'ın referansını bellekte tutar

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
           //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
           //konutKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}