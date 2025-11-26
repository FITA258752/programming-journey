using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJEK_FITA_AMALIA
{
    internal class Program
    {
        // Method untuk menghitung total harga
        static int HitungTotal(int harga, int jumlah)
        {
            return harga * jumlah;
        }
        static void Main(string[] args)
        {
            string noKursi;
            string[] jenisTiketArray = { "Reguler", "Ultra", "XD Ultra", "Gold" };
            int[] hargaArray = { 50000, 75000, 100000, 150000 };

            int pilihan, jumlahBeli, hargaSatuan, totalHarga;
            bool ulang = true;

            while (ulang)
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("      TIKET BIOSKOP SINEMA INDAH     ");
                Console.WriteLine("====================================");

                Console.Write("Masukkan No Kursi: ");
                noKursi = Console.ReadLine();

                Console.WriteLine("\nPilih Jenis Tiket:");
                for (int i = 0; i < jenisTiketArray.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {jenisTiketArray[i]} - Rp{hargaArray[i]}");
                }

                Console.Write("Masukkan pilihan (1-4): ");
                pilihan = int.Parse(Console.ReadLine());

                // Validasi pilihan
                if (pilihan < 1 || pilihan > 4)
                {
                    Console.WriteLine("Pilihan tidak valid!");
                    continue;
                }

                hargaSatuan = hargaArray[pilihan - 1];
                Console.WriteLine($"Harga Satuan: Rp{hargaSatuan}");

                Console.Write("Jumlah Beli: ");
                jumlahBeli = int.Parse(Console.ReadLine());

                // Hitung total harga dengan method
                totalHarga = HitungTotal(hargaSatuan, jumlahBeli);

                Console.WriteLine($"\nTotal Harga: Rp{totalHarga}");

                // Konfirmasi ulang
                Console.Write("\nIngin melakukan transaksi lagi? (y/n): ");
                string jawab = Console.ReadLine();
                if (jawab.ToLower() != "y")
                    ulang = false;
            }

            Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
            Console.ReadKey();
        }
    }
}
    

