namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Aytac","Hatice","Sami","Tugce"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Umut";
            //Console.WriteLine(isimler[5]);
            //Console.WriteLine(isimler[0]);

            // Diziler yerine genellikle koleksiyon kullanılır

            List<string> isimler2 = new List<string> { "Aytac", "Hatice", "Sami", "Tugce" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Umut");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}