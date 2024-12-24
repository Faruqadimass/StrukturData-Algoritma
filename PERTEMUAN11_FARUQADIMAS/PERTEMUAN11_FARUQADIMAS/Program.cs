using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN11_FARUQADIMAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nm, kd, nt, nh, mm, np;
            int ht, jp, htb, uk, ub;

            Console.WriteLine("----------PROGRAM TIKET----------");
            Console.WriteLine("---------------------------------");
            Console.Write(" NAMA PENUMPANG           : "); nm = Console.ReadLine();
            Console.Write(" NOMOR HP                 : "); nh = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" -----DAFTAR KODE TUJUAN------ ");
            Console.WriteLine();
            Console.Write(" [1]. PADANG = PD \n [2]. PALEMBANG = PL \n [3]. PEKANBARU = PK \n [4]. MEDAN = MDN \n [5]. LAMPUNG = LMP \n "); kd = Console.ReadLine();




            if (kd == "PD")
            {
                nt = "PADANG";
                ht = 200000;
                mm = "Audi Q8";
                np = "QR 1654 SR";

            }
            else if (kd == "PL")
            {
                nt = "PALEMBANG";
                ht = 150000;
                mm = "Daihatsu Terios";
                np = "QR 9637 ZH";

            }
            else if (kd == "PK")
            {
                nt = "PEKANBARU";
                ht = 250000;
                mm = "Wuling Cloud Ev";
                np = "QE 7942 CG";

            }
            else if (kd == "MDN")
            {
                nt = "MEDAN";
                ht = 300000;
                mm = "BYD M6";
                np = "LR 5782 KL";

            }
            else if (kd == "LMP")
            {
                nt = "LAMPUNG";
                ht = 400000;
                mm = "Toyota Inova Zenix";
                np = "RC 9822 MM";

            }
            else
            {
                nt = "TIDAK ADA";
                ht = 0;
                mm = "TIDAK ADA";
                np = "TIDAK ADA";
            }


            Console.WriteLine(" Tujuan Anda Keberangkatan Anda Adalah          : " + nt);
            Console.WriteLine(" Harga Tiket Anda Adalah     : " + ht);
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.Write(" SILAHKAN MASUKKAN JUMLAH PENUMPANG : ");
            jp = int.Parse(Console.ReadLine());
            Console.WriteLine();

            htb = jp * ht;
            Console.WriteLine(" JUMLAH PENUMPANG             : " + jp + " ORANG");
            Console.WriteLine(" TOTAL PEMBAYARAN ANDA ADALAH : Rp. " + htb + " rupiah");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();

            Console.Write(" JUMLAH UANG YANG DI BAYARKAN : ");
            ub = int.Parse(Console.ReadLine());

            uk = ub - htb;
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("----------------DATA KEBERANGKATAN PENUMPANG---------------");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" NAMA PENUMPANG                             : " + nm);
            Console.WriteLine(" Tujuan Keberangkatan Anda Adalah           : " + nt);
            Console.WriteLine(" DENGAN JUMLAH PENUMPANG                    : " + jp + " ORANG");
            Console.WriteLine(" MEREK MOBIL                                : " + mm);
            Console.WriteLine(" NOMOR POLISI                               : " + np);
            Console.WriteLine(" TOTAL PEMBAYARAN TIKET SEBESAR             : Rp. " + htb + " Rupiah");
            Console.WriteLine(" TOTAL UANG YANG ANDA BAYARKAN              : Rp. " + htb + " Rupiah");
            Console.WriteLine(" UANG KEMBALIAN ANDA ADALAH                 : Rp. " + uk + " Rupiah");

            Console.WriteLine();
            Console.WriteLine("------------TERIMA KASIH,SEMOGA PERJALANAN MU MENYENANGKAN----------------");
        }

    }
}

