namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id=2, CategoryId=5,UnitsInStock=5, ProductName="Kalem", UnitPrice=35};

            //PascalCase   //camelCase
            //case sensetive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int, double, bool... değer tip
            //diziler, class, abstract class, interface... referans tip

            //productManager.Topla2(3, 6);

            // void çıktıyı gösterirken, return değeri(sonucu) kullanmamızı sağlar örneğin
            // int toplamSonuc=productManager.Topla(3,6)
            // Console.WriteLine(toplamSonuc*2);
            //şeklinde işlemlerde kullanabiliriz ama bunu void'de yapamayız 
            //çünkü void çıktısını göstermekle mükelleftir.

            //int toplamSonuc = productManager.Topla(3, 6);
            //Console.WriteLine(toplamSonuc*2);

            //Console.WriteLine(productManager.Topla(3,6) * 2); şeklinde de çalışır


        }
    }
}
