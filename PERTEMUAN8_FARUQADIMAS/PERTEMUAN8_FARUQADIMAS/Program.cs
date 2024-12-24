using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERTEMUAN8_FARUQADIMAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Vnim, Vnm;
            int gp, tj, ti, ta, pot, gb;

            Console.WriteLine("program gaji karyawan pt.bbs");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("NIK                : "); Vnim = Console.ReadLine();
            Console.Write("nama karyawan      : "); Vnm = Console.ReadLine();
            Console.Write("gaji pokok         : "); gp = int.Parse(Console.ReadLine());
            Console.Write("tunjangan jabatan  : "); tj = int.Parse(Console.ReadLine());
            Console.Write("tunjangan istri    : "); ti = int.Parse(Console.ReadLine());
            Console.Write("tunjangan anak     : "); ta = int.Parse(Console.ReadLine());
            Console.Write("potongan           : "); pot = int.Parse(Console.ReadLine());

            gb = gp + tj + ti + ta - pot;

            Console.WriteLine();
            Console.WriteLine("gaji bersih = Rp " + gb + " Rupiah");

            Console.ReadKey();

        }
    }
}
