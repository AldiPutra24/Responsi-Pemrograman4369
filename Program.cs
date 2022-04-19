using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPemrog
{
	class Program
	{
		static void Main(string[] args)
		{
			Karyawan kry1 = new Karyawan();

			kry1.NIK = "21.11.4369";
			kry1.Nama = "Aldi Putra MU";
			kry1.GajiBulanan = 3000000;

			Karyawan kry2 = new Karyawan();

			kry2.NIK = "21.11.111";
			kry2.Nama = "paijo";
			kry2.GajiBulanan = 2000000;

			if (kry1.GajiBulanan < 0)
			{
				kry1.GajiBulanan = 0;
			}

			if (kry2.GajiBulanan < 0)
			{
				kry2.GajiBulanan = 0;
			}

			Console.WriteLine("No.\tNIK/Nama\t\tGaji Bulanan");
			Console.WriteLine("-----------------------------");
			Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.NIK, kry1.Nama, kry1.GajiBulanan);
			Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.NIK, kry2.Nama, kry2.GajiBulanan);

			Console.WriteLine("\n\n");
			Console.WriteLine("Asyiiik Kenaikan Gaji 10%");
			Console.WriteLine("\n");
			Console.WriteLine("No.\tNIK/Nama\t\tGaji Bulanan");
			Console.WriteLine("-----------------------------");
			Console.WriteLine("1.\t{0} {1}\t\t{2}", kry1.NIK, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
			Console.WriteLine("2.\t{0} {1}\t\t{2}", kry2.NIK, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
		}
	}
}
