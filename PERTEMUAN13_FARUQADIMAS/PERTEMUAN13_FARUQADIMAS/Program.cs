using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN13_FARUQADIMAS
{
    internal class Program
    {


        internal class program
        {
            static ArrayList nama = new ArrayList();
            static ArrayList no_hp = new ArrayList();
            static ArrayList tujuan = new ArrayList();
            static ArrayList harga = new ArrayList();

            static void header()
            {
                Console.WriteLine(" program arrylist tiket ");
                Console.WriteLine("===================");
            }
            static void tambahdata()
            {
                int jumlah;
                Console.WriteLine();
                Console.Write("masukkan banyak data penumpang yang ingin diinputkan : ");
                jumlah = int.Parse(Console.ReadLine());

                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine(" DATA KE " + (i + 1));
                    Console.WriteLine("---------------");
                    Console.Write("masukkan data nama : ");
                    nama.Add(Console.ReadLine());
                    Console.Write("masukkan data no hp : ");
                    no_hp.Add(Console.ReadLine());
                    Console.Write("masukkan data tujuan keberangkatan : ");
                    tujuan.Add(Console.ReadLine());
                    Console.Write("masukkan data harga : ");
                    harga.Add(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("data berhasil di tambahkan.");
                Console.WriteLine("=================================");
                Console.WriteLine();
            }
            static void tampilkansemua()
            {
                if (nama.Count == 0)
                {
                    Console.WriteLine("belum ada data yang dimasukkan");
                    return;
                }

                for (int i = 0; i < nama.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("=====================================");
                    Console.WriteLine("DATA PENUMPANG KE " + (i + 1));
                    Console.WriteLine("=====================================");
                    Console.WriteLine("nama                 : " + nama[i]);
                    Console.WriteLine("no hp                : " + no_hp[i]);
                    Console.WriteLine("tujuan keberangkatan : " + tujuan[i]);
                    Console.WriteLine("harga tiket          : " + harga[i]);
                    Console.WriteLine("======================================");
                }
            }

            static void Main(string[] args)
            {
                header();

                int pilihan = 0;

                while (true)
                {
                atas:
                    Console.WriteLine("pilihan :");

                    Console.WriteLine("1. tambah data");
                    Console.WriteLine("2. tampilkan semua data");
                    Console.WriteLine("3. bersihkan layar");
                    Console.WriteLine("4. keluar");
                    Console.WriteLine();
                    Console.Write("masukkan pilihan anda: ");
                    pilihan = int.Parse(Console.ReadLine());

                    if (pilihan == 1)
                    {
                        tambahdata();
                    }
                    else if (pilihan == 2)
                    {
                        tampilkansemua();
                    }
                    else if (pilihan == 3)
                    {
                        Console.Clear();
                        goto atas;
                    }
                    else if (pilihan == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("pilihan tidak valid.");
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}