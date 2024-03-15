using Microsoft.Win32.SafeHandles;
using System;

namespace KampReborn
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güveliği 
            // do not repeat yourself - Kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true ;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Sisteme girişiniz başaralıyla gerçekleşmiştir");
            }

            else
            {
                Console.WriteLine("Sisteme giriş işleminiz başarısız olmuştur");
            }
            Console.WriteLine(kategoriEtiketi);
            

        }
    }
}
