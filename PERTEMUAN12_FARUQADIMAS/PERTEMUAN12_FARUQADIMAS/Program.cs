using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN12_FARUQADIMAS
{
    internal class Program
    {


        static void persegipanjang()
        {
            int p, l, L;
            Console.Write(" MENCARI LUAS PERSEGI PANJANG");
            Console.WriteLine();
            Console.Write(" masukkan nilai panjang : "); p = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai lebar   : "); l = int.Parse(Console.ReadLine());

            L = p * l;

            Console.WriteLine();
            Console.Write(" Luas persegi panjang adalah " + L + " cm ");
        }

        static void segitiga()
        {
            int a, t, Ls;
            Console.Write(" MENCARI LUAS SEGITIGA");
            Console.WriteLine();
            Console.Write(" masukkan nilai atas    : "); a = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai tinggi  : "); t = int.Parse(Console.ReadLine());

            Ls = (a * t) / 2;
            Console.WriteLine();
            Console.Write(" Luas segitiga adalah " + Ls + " cm ");
        }

        static void balok()
        {
            int p, l, t, V;
            Console.Write(" MENCARI VOLUME BALOK");
            Console.WriteLine();
            Console.Write(" masukkan nilai panjang    : "); p = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai lebar      : "); l = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai tinggi     : "); t = int.Parse(Console.ReadLine());

            V = p * l * t;

            Console.WriteLine();
            Console.Write(" volume balok adalah " + V + " cm ");
        }

        static void persegiempat()
        {
            int s, K;
            Console.Write(" MENCARI KELILING PERSEGI EMPAT");
            Console.WriteLine();
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());

            K = s + s + s + s;

            Console.WriteLine();
            Console.Write(" keliling persegi empat adalah " + K + " cm ");
        }
        static void lingkaran()
        {
            int r, L;
            int v = 22 / 7;

            Console.Write(" MENCARI LUAS LINGKARAN");
            Console.WriteLine();
            Console.Write(" masukkan nilai jari - jari   : "); r = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai jari - jari   : "); r = int.Parse(Console.ReadLine());

            L = v * r * r;
            Console.WriteLine();
            Console.Write(" Luas lingkaran adalah " + L + " cm ");
        }
        static void trapesium()
        {
            int t, a, b, L;
            int v = 1 / 2;

            Console.Write(" MENCARI LUAS TRAPESIUM");
            Console.WriteLine();
            Console.Write(" masukkan nilai tinggi                 : "); t = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai panjang sisi sejajar A : "); a = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai panjang sisi sejajar B : "); b = int.Parse(Console.ReadLine());

            L = (v * t) + a * b;

            Console.WriteLine();
            Console.Write(" Luas trapesium adalah " + L + " cm ");
        }



        static void Main(string[] args)
        {
            int pilihan;
            string pilih;

        atas:
            Console.Write("[1]. persegi panjang \n[2]. segitiga\n[3]. balok\n[4]. persegi empat \n[5]. lingkaran \n[6]. trapesium\n" +
                "[7]. bersihkan layar\n\nMasukkan pilihan anda: ");
            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == 1)
            {
                persegipanjang();
            }
            else if (pilihan == 2)
            {
                segitiga();
            }
            else if (pilihan == 3)
            {
                balok();
            }
            else if (pilihan == 4)
            {
                persegiempat();
            }
            else if (pilihan == 5)
            {
                lingkaran();
            }
            else if (pilihan == 6)
            {
                trapesium();
            }
            else if (pilihan == 7)
            {
                Console.Clear();
                goto atas;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. silakan coba lagi.");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("APAKAH INGIN LANJUT MENCARI LUAS BANGUN YANG LAIN\n masukkan pilihan anda YES/NO  : ");
            pilih = Console.ReadLine();
            if (pilih == "YES")
            {
                goto atas;
            }
            else if (pilih == "NO")
            {
                Console.Clear();
                goto atas;
            }
            else
            {
                Console.Write(" tidak ada pilihan");
            }
        }
        static void Persegipanjang()
        {
            int p, l, L;
            Console.Write(" MENCARI LUAS PERSEGI PANJANG");
            Console.WriteLine();
            Console.Write(" masukkan nilai panjang : "); p = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai lebar   : "); l = int.Parse(Console.ReadLine());

            L = p * l;

            Console.WriteLine();
            Console.Write(" Luas persegi panjang adalah " + L + " cm ");
        }
        static void Segitiga()
        {
            int a, t, Ls;
            Console.Write(" MENCARI LUAS SEGITIGA");
            Console.WriteLine();
            Console.Write(" masukkan nilai atas    : "); a = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai tinggi  : "); t = int.Parse(Console.ReadLine());

            Ls = (a * t) / 2;

            Console.WriteLine();
            Console.Write(" Luas segitiga adalah " + Ls + " cm ");
        }
        static void Balok()
        {
            int p, l, t, V;
            Console.Write(" MENCARI VOLUME BALOK");
            Console.WriteLine();
            Console.Write(" masukkan nilai panjang    : "); p = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai lebar      : "); l = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai tinggi     : "); t = int.Parse(Console.ReadLine());

            V = p * l * t;

            Console.WriteLine();
            Console.Write(" volume balok adalah " + V + " cm ");
        }

        static void Persegiempat()
        {
            int s, K;
            Console.Write(" MENCARI KELILING PERSEGI EMPAT");
            Console.WriteLine();
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai sisi   : "); s = int.Parse(Console.ReadLine());

            K = s + s + s + s;

            Console.WriteLine();
            Console.Write(" keliling persegi empat adalah " + K + " cm ");
        }
        static void Lingkaran()
        {
            int r, L;
            int v = 22 / 7;

            Console.Write(" MENCARI LUAS LINGKARAN");
            Console.WriteLine();
            Console.Write(" masukkan nilai jari - jari   : "); r = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai jari - jari   : "); r = int.Parse(Console.ReadLine());

            L = v * r * r;

            Console.WriteLine();
            Console.Write(" Luas lingkaran adalah " + L + " cm ");
        }
        static void Trapesium()
        {
            int t, a, b, L;
            int v = 1 / 2;

            Console.Write(" MENCARI LUAS TRAPESIUM");
            Console.WriteLine();
            Console.Write(" masukkan nilai tinggi                 : "); t = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai panjang sisi sejajar A : "); a = int.Parse(Console.ReadLine());
            Console.Write(" masukkan nilai panjang sisi sejajar B : "); b = int.Parse(Console.ReadLine());
            L = (v * t) + a * b;

            Console.WriteLine();
            Console.Write(" Luas trapesium adalah " + L + " cm ");
        }


        static void main(string[] args)
        {
            int pilihan;
            string pilih;

        atas:
            Console.Write("[1]. persegi panjang \n[2]. segitiga\n[3]. balok\n[4]. persegi empat \n[5]. lingkaran \n[6]. trapesium\n" +
                "[7]. bersihkan layar\n\nMasukkan pilihan anda: ");
            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (pilihan == 1)
            {
                persegipanjang();
            }
            else if (pilihan == 2)
            {
                segitiga();
            }
            else if (pilihan == 3)
            {
                balok();
            }
            else if (pilihan == 4)
            {
                persegiempat();
            }
            else if (pilihan == 5)
            {
                lingkaran();
            }
            else if (pilihan == 6)
            {
                trapesium();
            }
            else if (pilihan == 7)
            {
                Console.Clear();
                goto atas;
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. silakan coba lagi.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("APAKAH INGIN LANJUT MENCARI LUAS BANGUN YANG LAIN\n masukkan pilihan anda YES/NO  : ");
            pilih = Console.ReadLine();
            if (pilih == "YES")
            {
                goto atas;
            }
            else if (pilih == "NO")
            {
                Console.Clear();
                goto atas;
            }
            else
            {
                Console.Write(" tidak ada pilihan");

            }
        }
    }
}