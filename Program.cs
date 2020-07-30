using System;
using System.Collections.Generic;

namespace HitungZakat
{
	class Program
	{
		//-------------------------------------------- MAIN PROGRAM --------------------------------------------//
		static void Main(string[] args)
		{
			MenuUtama();
		}
		//-------------------------------------------- JUDUL PROGRAM --------------------------------------------//
		private static void Judul()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\t\t=========================================================================");
			Console.WriteLine("\t\t=\t\t\tFinal Projek Pemrograman\t\t\t=");
			Console.WriteLine("\t\t=\t\t\t  Program Hitung Zakat\t\t\t\t=");
			Console.WriteLine("\t\t=========================================================================");
			Console.WriteLine();
		}
		//-------------------------------------------- MENU UTAMA --------------------------------------------//
		private static void MenuUtama()
		{
		Awal:
			Judul();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Menu Utama]");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t[1] Zakat Fitrah\t=>");
			Console.WriteLine("\t[2] Zakat Maal\t\t=>");
			Console.WriteLine("\t[3] Penerima\t\t=>");
			Console.WriteLine("\t[4] Keluar\t\t=>");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Input Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("\t=> Masukkan Pilihan : ");
			string MenuPilihan = Console.ReadLine();

			switch (MenuPilihan)
			{
				case "1":
					ZakatFitrah();
					break;
				case "2":
					ZakatMaal();
					break;
				case "3":
					Penerima();
					break;
				case "4":
					Keluar();
					break;
				case "9":
					HadirAnggota();
					break;
				default:
					Console.Clear();
					goto Awal;
			}
		}
		private static void Keluar()
        {
			Console.Clear();

			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t=========================================================");
			Console.WriteLine("\t=\tTerimakasih Telah menggunakan program kami\t=");
			Console.WriteLine("\t=========================================================");
			Console.ForegroundColor = ConsoleColor.White;
		}

		//-------------------------------------------- ZAKAT FITRAH --------------------------------------------//
		private static void ZakatFitrah()
		{
			Dulu ku;
			ku = new Dulu();

			Console.Clear();

			Judul();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Daftar Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t[1] Nama Kepala Keluarga\t\t\t    =>");
			Console.WriteLine("\t[2] Jumlah Anggota Keluarga\t\t\t    =>");
			Console.WriteLine("\t[3] Harga Beras 1 Kg \t\t\t\t    =>");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Input Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("\t=> Nama Kepala Keluarga\t\t\t[1] : ");
			string FitrahNama = Console.ReadLine();

			Console.Write("\t=> Jumlah Anggota Keluarga\t\t[2] : ");
			int Jumlah = Convert.ToInt32(Console.ReadLine());
			double FitrahBeras = Jumlah * 2.5;

			Console.Write("\t=> Harga Beras 1 Kg\t\t\t[3] : Rp. ");
			int Harga = Convert.ToInt32(Console.ReadLine());
			double FitrahUang = Harga * 2.5;

			//-------------------------------------------- OUTPUT --------------------------------------------//

			Console.Clear();
			Judul();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Output Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t=> Nama Kepala Keluarga\t\t[1] : {0} ", FitrahNama);
			Console.WriteLine("\t=> Zakat Yang Wajib Dikeluarkan\t[2] : {0} Kg Beras", FitrahBeras);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t\t\t\tATAU");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t=> Uang Pengganti Beras Sebesar\t[3] : Rp. {0}", FitrahUang);
			Console.ForegroundColor = ConsoleColor.DarkYellow;

			//-------------------------------------------- OUTPUT CLASS & OBJEK --------------------------------------------//
			Console.WriteLine();
			ku.Sudah();

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t----------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\t\t   Enter Untuk Kembali Ke Menu Utama");
			Console.ReadLine();
			Console.Clear();
			MenuUtama();
		}
		//-------------------------------------------- ZAKAT MAAL --------------------------------------------//
		private static void ZakatMaal()
		{
			Dulu ku;
			ku = new Dulu();

			Console.Clear();

			Judul();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Daftar Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t[1] Nama Anda\t\t\t\t\t    =>");
			Console.WriteLine("\t[2] Uang Anda Saat Ini\t\t\t\t    =>");
			Console.WriteLine("\t[3] Saldo Tabungan Anda\t\t\t\t    =>");
			Console.WriteLine("\t[4] Nominal Properti Anda\t\t\t    =>");
			Console.WriteLine("\t[5] Total Hutang Anda (Jika Ada)\t\t    =>");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Input Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("\t=> Nama Anda\t\t\t\t[1] : ");
			string MaalNama = Console.ReadLine();

			Console.Write("\t=> Uang Anda Saat Ini\t\t\t[2] : Rp. ");
			int Sekarang = Convert.ToInt32(Console.ReadLine());

			Console.Write("\t=> Saldo Tabungan Anda\t\t\t[3] : Rp. ");
			int Tabungan = Convert.ToInt32(Console.ReadLine());

			Console.Write("\t=> Nominal Properti Anda\t\t[4] : Rp. ");
			int Properti = Convert.ToInt32(Console.ReadLine());

			Console.Write("\t=> Total Hutang Anda (Jika Ada)\t\t[5] : Rp. ");
			int Hutang = Convert.ToInt32(Console.ReadLine());

			int Total = (Sekarang + Tabungan + Properti) - Hutang;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Total & Hitung Nishab]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t=> Total Harta Anda\t\t\t: Rp. {0}", Total);
			Console.Write("\t=> Harga 1 gram Emas 24 Karat\t\t: Rp. ");
			int Emas = Convert.ToInt32(Console.ReadLine());
			int Nishab = Emas * 85;
			Console.WriteLine("\t=> Nishab Zakat (85 gram Emas)\t\t: Rp. {0}", Nishab);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\t\t\tEnter Untuk Melihat Output");
			Console.ReadLine();

			//-------------------------------------------- OUTPUT --------------------------------------------//

			if (Total >= Nishab)
			{
				Console.Clear();
				Judul();

				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\t[Output Data]");
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("\t----------------------------------------------------------");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("\t=> Nama Anda\t: {0}", MaalNama);
				double zakat = Total * 0.025;
				Console.WriteLine("\t=> Status\t: Wajib Zakat");
				Console.WriteLine("\t=> Wajib Zakat\t: Rp. {0}", zakat);

				//-------------------------------------------- OUTPUT CLASS & OBJEK --------------------------------------------//
				Console.WriteLine();
				ku.Sudah();

				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("\t----------------------------------------------------------");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\t\t\tEnter Untuk Kembali Ke Menu Utama");
				Console.ReadLine();
				Console.Clear();
				MenuUtama();
			}
			else
			{
				Console.Clear();
				Judul();
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("\t[Output Data]");
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("\t----------------------------------------------------------");
				Console.ForegroundColor = ConsoleColor.DarkCyan;
				Console.WriteLine("\t=> Nama Anda\t: {0}", MaalNama);
				Console.WriteLine("\t=> Status\t: Tidak Wajib Zakat");
				Console.WriteLine();

				//-------------------------------------------- OUTPUT CLASS & OBJEK --------------------------------------------//
				Console.WriteLine();
				ku.Sudah();

				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("\t----------------------------------------------------------");
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine("\t\t\tEnter Untuk Kembali Ke Menu Utama");
				Console.ReadLine();
				Console.Clear();
				MenuUtama();
			}
		}
		//-------------------------------------------- PENERIMA --------------------------------------------//
		private static void Penerima()
		{
			Console.Clear();
			Judul();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\tAda 8 Golongan Orang Yang Berhak Menerima Zakat, Yaitu : ");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t=> [1] Fakir");
			Console.WriteLine("\t=> [2] Miskin");
			Console.WriteLine("\t=> [3] Amil");
			Console.WriteLine("\t=> [4] Mu'allaf");
			Console.WriteLine("\t=> [5] Riqab / Memerdekakan Budak");
			Console.WriteLine("\t=> [6] Gharim (Orang yang Memiliki Hutang)");
			Console.WriteLine("\t=> [7] Fi Sabilillah");
			Console.WriteLine("\t=> [8] Ibnu Sabil");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t-------------------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\t\t     Enter Untuk Kembali Ke Menu Utama");
			Console.ReadLine();
			Console.Clear();
			MenuUtama();
		}
		//-------------------------------------------- INHERITANCE --------------------------------------------//
		private static void HadirAnggota()
        {
			Dua:
			Console.Clear();
			Judul();

			IHadirAnggota anggotaku = new HadirAnggota();

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Daftar Data Anggota]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("\t[1] Dian Pratama");
			Console.WriteLine("\t[2] Naima Zulfa");
			Console.WriteLine("\t[3] Wahyu Nugroho");
			Console.WriteLine("\t[4] Lilis Widiyanti");
			Console.WriteLine("\t[5] Addnan Nurwakhid");
			Console.WriteLine("\t[6] Hernanda Giri Pramudita");
			Console.WriteLine("\t[7] Kembali");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------------------");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Input Data]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write("\tNomer Anggota [1..7] : ");
			int nomor = Convert.ToInt32(Console.ReadLine());

			switch (nomor)
            {
				case 1:
					anggotaku = new Dian();
					break;
				case 2:
					anggotaku = new Zulfa();
					break;
				case 3:
					anggotaku = new Wahyu();
					break;
				case 4:
					anggotaku = new Lilis();
					break;
				case 5:
					anggotaku = new Addnan();
					break;
				case 6:
					anggotaku = new Giri();
					break;
				case 7:
					Console.Clear();
					MenuUtama();
					break;
				default:
					goto Dua;
            }

			//-------------------------------------------- OUTPUT INHERITANCE --------------------------------------------//

			Console.Clear();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\t[Data Anggota]");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			anggotaku.Nama();
			anggotaku.NIM();
			anggotaku.Jabatan();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("\t---------------------------------------------------");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\t\tEnter Untuk Kembali Ke Menu Anggota");
			Console.ReadLine();
			Console.Clear();
			goto Dua;
		}
	}
	//-------------------------------------------- PROSESS INHERITANCE --------------------------------------------//
	interface IHadirAnggota
	{
		void Nama();
		void NIM();
		void Jabatan();
	}

	class HadirAnggota : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: ");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: ");
		}
		public void Jabatan()
        {
			Console.WriteLine("\t=> Jabatan\t: ");
		}
	}
	public class Dian : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: Dian Pratama");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: 19.11.2763");
		}
		public void Jabatan()
		{
			Console.WriteLine("\t=> Jabatan\t: Ketua Kelompok");
		}
	}
	public class Wahyu : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: Wahyu Nugroho");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: 19.11.2741");
		}
		public void Jabatan()
		{
			Console.WriteLine("\t=> Jabatan\t: Anggota Kelompok");
		}
	}
	public class Zulfa : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: Naima Zulfa");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: 19.11.2735");
		}
		public void Jabatan()
		{
			Console.WriteLine("\t=> Jabatan\t: Anggota Kelompok");
		}
	}
	public class Addnan : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: Addnan Nurwakhid");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: 19.11.2736");
		}
		public void Jabatan()
		{
			Console.WriteLine("\t=> Jabatan\t: Anggota Kelompok");
		}
	}
	public class Giri : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: Hernanda Giri Pramudita");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: 19.11.2761");
		}
		public void Jabatan()
		{
			Console.WriteLine("\t=> Jabatan\t: Anggota Kelompok");
		}
	}
	public class Lilis : IHadirAnggota
	{
		public void Nama()
		{
			Console.WriteLine("\t=> Nama Saya\t: Lilis Widiyanti");
		}
		public void NIM()
		{
			Console.WriteLine("\t=> NIM Saya\t: 19.11.2774");
		}
		public void Jabatan()
		{
			Console.WriteLine("\t=> Jabatan\t: Anggota Kelompok");
		}
	}
	//-------------------------------------------- CLASS & OBJEK --------------------------------------------//
	class Dulu
    {
		public void Sudah()
        {
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(("\t=>\tStatus Program : Zakat Anda Sudah Terhitung\t<="));
		}
    }
}