using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();
            int code;
            string tanggal, name, jenis1;
            string jenis2= "Kesalahan" ;
            double jum;

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine("");
            Console.Write("Nota       : ");
            code = int.Parse(Console.ReadLine());

            Console.Write("Tanggal    : ");
            tanggal = Console.ReadLine();

            Console.Write("Cutomer    : ");
            name = Console.ReadLine();

            Console.Write("Jenis [T/K]: ");
            jenis1 = Console.ReadLine();
            
            Console.Write("Total Nota : ");
            jum = int.Parse(Console.ReadLine());

            if (jenis1 == "T")
            {
                jenis2 = "Tunai";
            }
            if (jenis1 == "K")
            {
                jenis2 = "kredit";
            }
            daftarPenjualan.Add(new Penjualan() { Kode = code, Tanggal = tanggal, Nama=name, Jenis=jenis2, Total=jum});
            // PERINTAH: lengkapi kode untuk menambahkan customer ke dalam collection
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            int hapus;
            bool k = false;
            Console.WriteLine("Hapus data Penjual");
            Console.WriteLine("");
            Console.Write("Nota : ");
            hapus = int.Parse(Console.ReadLine());
            int x = 0;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                if (hapus == daftar.Kode)
                {
                    daftarPenjualan.RemoveAt(x);
                    k = true;
                    break;
                }
                x++;
            }
            if(k)
            {
                Console.WriteLine("Data penjualan berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Nota tidak ditemukan");
            }
            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            Console.WriteLine("Data Penjualan");
            Console.WriteLine("");
            int no = 1;
            foreach (Penjualan daftar in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}",
                no, daftar.Kode, daftar.Tanggal, daftar.Nama, daftar.Jenis, daftar.Total);
                no++;
            }
            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("");
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
