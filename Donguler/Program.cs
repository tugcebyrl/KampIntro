namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici...";
            string kurs2 = "Programlamaya Başlangıç...";
            string kurs3 = "Python";

            //array 
            string[] kurslar = new string[] {"Yazılım Geliştirici...","Programlamaya Başlangıç...","Python","Java","C#"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("FOR BITTI");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}