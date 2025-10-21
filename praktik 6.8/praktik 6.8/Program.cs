using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik_6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- Blok Proses yang Akan Diulang ---
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Masukkan nama Anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Hallo, {nama}! Proses telah selesai.");
                //---------------------------------------
                // Pertanyaan untuk Mengulang 
                Console.WriteLine("Apakah anda ingin mengulangi lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(). // Mengambilinput dan mengubahke huruf kecil

                Console.WriteLine(); // Baris kosong unntuk kerapian

                // Kondisi dipwriksa di akhir: Ulangi selama penggunaan mengetik "iya"
            } while (ulangiPilihan == "ya");
            Console.WriteLine("Terima kasih. Program selesai.");
        }
    }
}
