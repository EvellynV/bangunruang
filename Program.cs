using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar file = new BangunDatar();

            file.luas_persegi();
            file.luas_segitiga();
            file.luas_lingkaran();

            BangunRuang file2 = new BangunRuang();

            file2.volume_balok();
            file2.volume_kubus();
        }
    }
}
