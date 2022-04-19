using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPemrog
{
	public class Karyawan
	{
		public Karyawan()
		{
		}
		public Karyawan(string NIK, string Nama, int GajiBulanan)
		{
			if (GajiBulanan < 0)
			{
				Console.WriteLine("Gaji harus diatas 0!");
			}
			else
			{
				Console.WriteLine("blok");
			}
		}
		public string NIK {get ; set ;}
		public string Nama {get ; set ;}
		public int GajiBulanan {get ; set ;}
	}
}
