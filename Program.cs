using System;

namespace Array_sınıfı_metodları 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sort

            Console.WriteLine("----Sırasız Dizi----");

            int[] sayiDizisi = {2, 23, 3, 45, 86, 12, 21, 8, 94, 156};
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("----Sıralı Dizi----");

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // clear

            Console.WriteLine("----Array Clear----");

            Array.Clear(sayiDizisi,2,2);// ikinci indexten başlayarak iki tane elemanı temizle
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse

            Console.WriteLine("----Reverse----");

            Array.Reverse(sayiDizisi,0,5); // 0. index ve 5. index arasını reverse et
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // IndexOf

            Console.WriteLine("----IndexOf----");

            Console.WriteLine(Array.IndexOf(sayiDizisi,156));

            // Resize

            Console.WriteLine("----Resize----"); // Dizinin boyutunu 11 yap -Dizinin boyutunu genişletmek

            Array.Resize<int>(ref sayiDizisi,11);

            sayiDizisi[10] = 1;
            
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}