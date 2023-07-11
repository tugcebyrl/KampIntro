namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Tugce");
            isimler.Add("Tugce2");
            isimler.Add("Tugce3");
        }
    }
}