using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
	class Program
	{
		static void Main(string[] args)
		{
			ResponsiPemrograman4369 kry1 = new ResponsiPemrograman4369();

			kry1.NIK = "18112265";
			kry1.Nama = "Fakhrian";
			kry1.GajiBulanan = "3000000";

			karyawan kry2 = new Karyawan();

			kry2.NIK = "18112266";
			kry2.Nama = "Ikhwaludin";
			kry2.GajiBulanan = "2000000";

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