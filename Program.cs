using System;

namespace diziler_array_sinifi_methodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort : Bir dizideki elemanları küçükten büyüğe sıralar.
            int [] sayiDizisi = {8,23,96,54,55,32,12,24};
            
            Console.WriteLine("**** Sırasız Dizi ****");
            foreach(var item in sayiDizisi)
                Console.WriteLine(item);

            Array.Sort(sayiDizisi); // İçeride verilen dizi sıralanır ve 
                                    // direk o dizi üzerinde değişiklik yapılır.

            Console.WriteLine("**** Sıralı Dizi ****");
            foreach(var item in sayiDizisi)
                Console.WriteLine(item);

            // Clear : İstenilen elemanları 0'lamayı sağlar. İndex ve kaç eleman 0'lanacaksa o bilgi verilir.

            Console.WriteLine("**** Array Clear ****");
            Array.Clear(sayiDizisi,2,2); // 2.indexten başlayarak 2 elemanı 0'la demek.

            foreach(var item in sayiDizisi)
                Console.WriteLine(item);

            // Reverse : Verilen diziyi ters çevirir. Son eleman 1. eleman olur ilk eleman sona gelir.
            // Yani sondan başlayarak diziyi tekrar yazar.

            Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayiDizisi); // Ters çevirir

            foreach(var item in sayiDizisi)
                Console.WriteLine(item);

            // IndexOf : Verilen diziyi içerisinden bir elemanın index'ini bulmayı sağlar.

            Console.WriteLine("**** Array IndexOf ****");
            int siralama = Array.IndexOf(sayiDizisi,12); // Elemanın index'ini alıyoruz.

            foreach(var item in sayiDizisi)
                Console.WriteLine(item);

            Console.WriteLine("Aradığınız eleman {0}.Sırada.", siralama+1);

            // Resize : Verilen dizinin kaydedebileceği eleman sayısını artırmak için kullanılır.

            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9); // Verilen dizinin boyutu 8 di 9 yapar.
            sayiDizisi[8] = 101;

            foreach(var item in sayiDizisi)
                Console.WriteLine(item);


        }
    }
}

