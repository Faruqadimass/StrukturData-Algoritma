using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN14_FARUQADIMAS
{
    internal class Program
    {


        internal class klinik
        {
            static ArrayList nama_klinik = new ArrayList();
            static ArrayList no_telepon = new ArrayList();
            static ArrayList noizin_operasional = new ArrayList();
            static ArrayList no_pasien = new ArrayList();
            static ArrayList dokter_penanggungjawab = new ArrayList();
            static ArrayList fasilitas_alatpendukung = new ArrayList();
            static ArrayList sistem_pembayaran = new ArrayList();

            static void header()
            {
                Console.WriteLine(" program arrylist tiket ");
                Console.WriteLine("===================");
            }
            static void tambahdata()
            {
                int jumlah;
                Console.WriteLine();
                Console.Write("masukkan data klinik yang ingin diinputkan : ");
                jumlah = int.Parse(Console.ReadLine());

                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine(" DATA KELINIK" + (i + 1));
                    Console.WriteLine("---------------");
                    Console.Write("masukkan data nama klinik: ");
                    nama_klinik.Add(Console.ReadLine());
                    Console.Write("masukkan data no telepon : ");
                    no_telepon.Add(Console.ReadLine());
                    Console.Write("no izin oprasional : ");
                    noizin_operasional.Add(Console.ReadLine());
                    Console.Write("no pasien : ");
                    no_pasien.Add(Console.ReadLine());
                    Console.Write("dokter penanggung jawab : ");
                    dokter_penanggungjawab.Add(Console.ReadLine());
                    Console.Write("masukkan data konsultasi spesialis : ");
                    fasilitas_alatpendukung.Add(Console.ReadLine());
                    Console.Write("sistem pembayaran: ");
                    sistem_pembayaran.Add(Console.ReadLine());


                }
                Console.WriteLine();
                Console.WriteLine("=================================");
                Console.WriteLine("data berhasil di tambahkan.");
                Console.WriteLine("=================================");
                Console.WriteLine();
            }
            static void tampilkansemua()
            {
                if (nama_klinik.Count == 0)
                {
                    Console.WriteLine("belum ada data yang dimasukkan");
                    return;
                }

                for (int i = 0; i < nama_klinik.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("=====================================");
                    Console.WriteLine("DATA KINIK " + (i + 1));
                    Console.WriteLine("=====================================");
                    Console.WriteLine("nama klinik               : " + nama_klinik[i]);
                    Console.WriteLine("no telepon                : " + no_telepon[i]);
                    Console.WriteLine("no izin operasional       : " + noizin_operasional[i]);
                    Console.WriteLine("no_pasien                 : " + nama_klinik[i]);
                    Console.WriteLine("fasilitas alat pendukung  : " + fasilitas_alatpendukung[i]);
                    Console.WriteLine("sistem pembayaran         : " + sistem_pembayaran[i]);

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