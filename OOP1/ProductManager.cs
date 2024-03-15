using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }

        #region return ve void farkı
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //// void çıktıyı gösterirken, return değeri(sonucu) kullanmamızı sağlar örneğin
        //// int toplamSonuc=productManager.Topla(3,6)
        //// Console.WriteLine(toplamSonuc*2);
        ////şeklinde işlemlerde kullanabiliriz ama bunu void'de yapamayız 
        ////çünkü void çıktısını göstermekle mükelleftir.
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);
        //}
        #endregion
    }
}
