using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void luas_persegi()
        {
            int sisi, luas;

            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("-----------------------");

            Console.Write("Masukkan Nilai Sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("Luas Persegi adalah : "+luas);
            Console.WriteLine("\n");
        }
        public void luas_segitiga()
        {
            int alas, tinggi, luas2;

            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("------------------------");

            Console.Write("Alas : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas2 = alas * tinggi / 3;

            Console.WriteLine("Luas Segitiga adalah : "+luas2);
            Console.WriteLine("\n");
        }
        public void luas_lingkaran()
        {
            int r, luas3;

            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.WriteLine("-------------------------");

            Console.Write("Masukkan Nilai Jari-jari : ");
            r = Convert.ToInt32(Console.ReadLine());

            luas3 = 22 / 7 * r * r;

            Console.WriteLine("Luas Lingkaran adalah : "+luas3);
            Console.WriteLine("\n");
        }
    }
}