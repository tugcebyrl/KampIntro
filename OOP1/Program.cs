using System.Runtime.InteropServices;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Tanımlama Sekli
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            // 2. Tanımlama Sekli

            Product product2 = new Product {Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice=50, UnitsInStock=100};
            
            //case sensitive
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();

            //referans tip
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //deger tip
            //int sayi = 100;
            //productManager.BirSeyYap(sayi);
            //Console.WriteLine(sayi);

            productManager.Topla2(3, 6);

            int toplamSonucu = productManager.Topla(7,6);
            Console.WriteLine(toplamSonucu);
        }
    }
}