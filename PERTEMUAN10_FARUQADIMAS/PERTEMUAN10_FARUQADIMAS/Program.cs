using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN10_FARUQADIMAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gp, tj, pot, ttlgj, kp;
            string nm, kd, nj;
            kp = 150000;

            Console.WriteLine("program gaji karyawan");
            Console.WriteLine("---------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("nama kayrawan : "); nm = Console.ReadLine();
            Console.Write("kode jabatan  : "); kd = Console.ReadLine();
            Console.WriteLine();

            if (kd == "MG")
            {
                nj = "manager";
                gp = 4000000;
                tj = 2000000;
                pot = 500000;
            }
            else if (kd == "KB")
            {
                nj = "kepala bagian";
                gp = 3500000;
                tj = 1500000;
                pot = 400000;
            }
            else if (kd == "SB")
            {
                nj = "staf bagian";
                gp = 3000000;
                tj = 1300000;
                pot = 300000;
            }
            else if (kd == "OB")
            {
                nj = "office boy";
                gp = 1800000;
                tj = 500000;
                pot = 100000;
            }
            else if (kd == "MRKT")
            {
                nj = "marketing";
                gp = 2500000;
                tj = 1200000;
                pot = 200000;
            }
            else if (kd == "SL")
            {
                nj = "sales";
                gp = 2700000;
                tj = 1000000;
                pot = 2000000;
            }
            else
            {
                nj = "tidak ada";
                gp = 0;
                tj = 0;
                pot = 0;
            }

            Console.WriteLine("hallo " + nm + " jabatan " + nj + " berikut rekapan gaji bulan ini");
            Console.WriteLine();
            Console.WriteLine("nama jabatan : " + nj);
            Console.WriteLine("tunjangan    : " + tj);
            Console.WriteLine("potongan     : " + pot);
            Console.WriteLine("koprasi      : " + kp);
            Console.WriteLine();

            ttlgj = gp + tj - pot - kp;

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("total gaji bersih kamu bulan ini sebesar = Rp." + ttlgj + ",00");

            Console.ReadKey();

        }
    }
}
