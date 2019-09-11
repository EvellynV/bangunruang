using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void volume_balok()
        {
            int panjang, lebar, tinggi, volume;

            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-----------------------");

            Console.Write("Panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume Balok adalah : "+volume);
            Console.WriteLine("\n");
        }
        public void volume_kubus()
            {
                int sisi, volume2;

                Console.WriteLine("Menghitung Volume Kubus");
                Console.WriteLine("-----------------------");

                Console.Write("Masukkan Nilai Sisi : ");
                sisi = Convert.ToInt32(Console.ReadLine());

                volume2 = sisi * sisi * sisi;

                Console.WriteLine("Volume Kubus adalah : "+volume2);
            }
    }
}